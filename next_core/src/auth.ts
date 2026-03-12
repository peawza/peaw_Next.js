import NextAuth from "next-auth";
import Credentials from "next-auth/providers/credentials";
import type { BackendLoginResponse } from "@/types";

type LoginResponseEnvelope = {
  data?: BackendLoginResponse;
  result?: BackendLoginResponse;
};

function asBackendLoginResponse(input: unknown): BackendLoginResponse | null {
  if (!input || typeof input !== "object") {
    return null;
  }

  const candidate = input as Partial<BackendLoginResponse>;
  if (typeof candidate.Token === "string" && typeof candidate.Id === "string") {
    return candidate as BackendLoginResponse;
  }

  return null;
}

function getLoginPayload(input: unknown): BackendLoginResponse | null {
  const directPayload = asBackendLoginResponse(input);
  if (directPayload) {
    return directPayload;
  }

  if (input && typeof input === "object") {
    const envelope = input as LoginResponseEnvelope;
    return asBackendLoginResponse(envelope.data) ?? asBackendLoginResponse(envelope.result);
  }

  return null;
}

function buildLoginEndpoint(): string | null {
  const apiBaseUrl = process.env.AUTH_API_URL ?? process.env.NEXT_PUBLIC_API_URL;
  const loginPath = process.env.AUTH_LOGIN_PATH ?? "/auth/login";

  if (!apiBaseUrl) {
    return null;
  }

  if (/^https?:\/\//i.test(loginPath)) {
    return loginPath;
  }

  const normalizedBaseUrl = apiBaseUrl.endsWith("/") ? apiBaseUrl.slice(0, -1) : apiBaseUrl;
  const normalizedPath = loginPath.startsWith("/") ? loginPath : `/${loginPath}`;
  return `${normalizedBaseUrl}${normalizedPath}`;
}

export const { handlers, auth, signIn, signOut } = NextAuth({
  pages: {
    signIn: "/login",
  },
  session: {
    strategy: "jwt",
  },
  providers: [
    Credentials({
      name: "Credentials",
      credentials: {
        username: { label: "Username", type: "text" },
        password: { label: "Password", type: "password" },
        languageCode: { label: "Language Code", type: "text" },
      },
      authorize: async (credentials) => {
        const username = credentials?.username?.toString().trim();
        const password = credentials?.password?.toString();
        const languageCode = credentials?.languageCode?.toString() || "en";
        const loginEndpoint = buildLoginEndpoint();

        if (!username || !password || !loginEndpoint) {
          return null;
        }

        try {
          const response = await fetch(loginEndpoint, {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
            },
            body: JSON.stringify({
              UserName: username,
              Password: password,
              LanguageCode: languageCode,
            }),
            cache: "no-store",
          });

          if (!response.ok) {
            return null;
          }

          const rawPayload: unknown = await response.json();
          const loginPayload = getLoginPayload(rawPayload);

          if (!loginPayload) {
            return null;
          }

          return {
            id: loginPayload.Id,
            name: loginPayload.DisplayName,
            email: loginPayload.UserName,
            userName: loginPayload.UserName,
            displayName: loginPayload.DisplayName,
            languageCode: loginPayload.LanguageCode,
            accessToken: loginPayload.Token,
            refreshToken: loginPayload.RefreshToken,
            customerId: loginPayload.CustomerID,
            permissionScreen: loginPayload.PermissionScreen,
            timeout: loginPayload.Timeout,
            userNumber: loginPayload.UserNumber,
          };
        } catch {
          return null;
        }
      },
    }),
  ],
  callbacks: {
    async jwt({ token, user }) {
      if (user) {
        token.id = user.id;
        token.name = user.name;
        token.email = user.email;
        token.userName = user.userName;
        token.displayName = user.displayName;
        token.languageCode = user.languageCode;
        token.accessToken = user.accessToken;
        token.refreshToken = user.refreshToken;
        token.customerId = user.customerId;
        token.permissionScreen = user.permissionScreen;
        token.timeout = user.timeout;
        token.userNumber = user.userNumber;
      }

      return token;
    },
    async session({ session, token }) {
      const resolvedUserId =
        typeof token.id === "string"
          ? token.id
          : typeof session.user?.id === "string"
            ? session.user.id
            : "";

      session.user = {
        ...session.user,
        id: resolvedUserId,
        name: typeof token.displayName === "string" ? token.displayName : session.user?.name,
        email: typeof token.userName === "string" ? token.userName : session.user?.email,
      };

      session.accessToken = typeof token.accessToken === "string" ? token.accessToken : undefined;
      session.refreshToken =
        typeof token.refreshToken === "string" ? token.refreshToken : undefined;
      session.languageCode =
        typeof token.languageCode === "string" ? token.languageCode : undefined;
      session.customerId = typeof token.customerId === "number" ? token.customerId : undefined;
      session.permissionScreen =
        typeof token.permissionScreen === "string" ? token.permissionScreen : undefined;
      session.timeout = typeof token.timeout === "number" ? token.timeout : undefined;
      session.userNumber = typeof token.userNumber === "number" ? token.userNumber : undefined;

      return session;
    },
  },
});
