import NextAuth from "next-auth";
import Credentials from "next-auth/providers/credentials";
import type { JWT } from "next-auth/jwt";
import type { BackendLoginResponse } from "@/types";
import { getJwtExp, isAccessTokenExpired } from "@/lib/authToken";

type LoginResponseEnvelope = {
  data?: BackendLoginResponse;
  result?: BackendLoginResponse;
  payload?: BackendLoginResponse;
  value?: BackendLoginResponse;
};

type RefreshTokenResponse = {
  Token: string;
  RefreshToken: string;
  Timeout: number;
};

function asString(input: unknown): string | null {
  if (typeof input === "string" && input.trim() !== "") {
    return input;
  }
  if (typeof input === "number" && Number.isFinite(input)) {
    return String(input);
  }
  return null;
}

function asNumber(input: unknown, fallback = 0): number {
  if (typeof input === "number" && Number.isFinite(input)) {
    return input;
  }
  if (typeof input === "string" && input.trim() !== "") {
    const parsed = Number(input);
    if (Number.isFinite(parsed)) {
      return parsed;
    }
  }
  return fallback;
}

function parseJsonOrNull(input: string): unknown {
  if (!input || input.trim() === "") {
    return null;
  }

  try {
    return JSON.parse(input) as unknown;
  } catch {
    return null;
  }
}

function toRefreshTokenResponse(input: unknown): RefreshTokenResponse | null {
  if (!input || typeof input !== "object" || Array.isArray(input)) {
    return null;
  }

  const candidate = input as Record<string, unknown>;
  const token = asString(candidate.Token ?? candidate.token ?? candidate.AccessToken);
  const refreshToken =
    asString(candidate.RefreshToken ?? candidate.refreshToken ?? candidate.Refresh) ?? "";

  if (!token || !refreshToken) {
    return null;
  }

  return {
    Token: token,
    RefreshToken: refreshToken,
    Timeout: asNumber(candidate.Timeout ?? candidate.timeout, 0),
  };
}

function toBackendLoginResponse(input: unknown): BackendLoginResponse | null {
  if (!input || typeof input !== "object" || Array.isArray(input)) {
    return null;
  }

  const candidate = input as Record<string, unknown>;

  const id = asString(candidate.Id ?? candidate.id ?? candidate.UserId ?? candidate.userId);
  const token = asString(candidate.Token ?? candidate.token ?? candidate.AccessToken);
  const refreshToken =
    asString(candidate.RefreshToken ?? candidate.refreshToken ?? candidate.Refresh) ?? "";
  const userName =
    asString(candidate.UserName ?? candidate.userName ?? candidate.Username ?? candidate.username) ??
    "";
  const languageCode =
    asString(candidate.LanguageCode ?? candidate.languageCode ?? candidate.Language) ?? "en";
  const displayName = asString(candidate.DisplayName ?? candidate.displayName) ?? userName;

  if (!id || !token) {
    return null;
  }

  return {
    Id: id,
    UserNumber: asNumber(candidate.UserNumber ?? candidate.userNumber, 0),
    UserName: userName,
    LanguageCode: languageCode,
    DisplayName: displayName,
    Token: token,
    RefreshToken: refreshToken,
    CustomerID: asNumber(candidate.CustomerID ?? candidate.customerId, 0),
    PermissionScreen:
      asString(candidate.PermissionScreen ?? candidate.permissionScreen ?? "{}") ?? "{}",
    Timeout: asNumber(candidate.Timeout ?? candidate.timeout, 0),
  };
}

function getLoginPayload(input: unknown, depth = 0): BackendLoginResponse | null {
  if (depth > 4 || !input) {
    return null;
  }

  const directPayload = toBackendLoginResponse(input);
  if (directPayload) {
    return directPayload;
  }

  if (input && typeof input === "object") {
    const envelope = input as LoginResponseEnvelope;

    const nestedPayload =
      getLoginPayload(envelope.data, depth + 1) ??
      getLoginPayload(envelope.result, depth + 1) ??
      getLoginPayload(envelope.payload, depth + 1) ??
      getLoginPayload(envelope.value, depth + 1);

    if (nestedPayload) {
      return nestedPayload;
    }

    for (const value of Object.values(input as Record<string, unknown>)) {
      const found = getLoginPayload(value, depth + 1);
      if (found) {
        return found;
      }
    }
  }

  return null;
}

function getRefreshTokenPayload(input: unknown, depth = 0): RefreshTokenResponse | null {
  if (depth > 4 || !input) {
    return null;
  }

  const directPayload = toRefreshTokenResponse(input);
  if (directPayload) {
    return directPayload;
  }

  if (typeof input === "object" && !Array.isArray(input)) {
    const envelope = input as Record<string, unknown>;

    const nestedPayload =
      getRefreshTokenPayload(envelope.data, depth + 1) ??
      getRefreshTokenPayload(envelope.result, depth + 1) ??
      getRefreshTokenPayload(envelope.payload, depth + 1) ??
      getRefreshTokenPayload(envelope.value, depth + 1);

    if (nestedPayload) {
      return nestedPayload;
    }

    for (const value of Object.values(envelope)) {
      const found = getRefreshTokenPayload(value, depth + 1);
      if (found) {
        return found;
      }
    }
  }

  return null;
}

function buildApiEndpoint(path: string | undefined, fallbackPath: string): string | null {
  const apiBaseUrl = process.env.AUTH_API_URL ?? process.env.NEXT_PUBLIC_API_URL;
  const apiPath = path ?? fallbackPath;

  if (!apiBaseUrl) {
    return null;
  }

  if (/^https?:\/\//i.test(apiPath)) {
    return apiPath;
  }

  const normalizedBaseUrl = apiBaseUrl.endsWith("/") ? apiBaseUrl.slice(0, -1) : apiBaseUrl;
  const normalizedPath = apiPath.startsWith("/") ? apiPath : `/${apiPath}`;
  return `${normalizedBaseUrl}${normalizedPath}`;
}

function buildLoginEndpoint(): string | null {
  return buildApiEndpoint(process.env.AUTH_LOGIN_PATH, "/auth/login");
}

function buildRefreshEndpoint(): string | null {
  return buildApiEndpoint(process.env.AUTH_REFRESH_PATH, "/api/auth/SSS010/FirstLogin");
}

function getTokenRefreshError(token: JWT): JWT {
  return {
    ...token,
    accessToken: undefined,
    accessTokenExpiresAt: undefined,
    authError: "RefreshAccessTokenError",
  };
}

async function refreshAccessToken(token: JWT): Promise<JWT> {
  const refreshEndpoint = buildRefreshEndpoint();
  const userName = asString(token.userName);
  const refreshToken = asString(token.refreshToken);
  const languageCode = asString(token.languageCode) ?? "en";

  if (!refreshEndpoint || !userName || !refreshToken) {
    return getTokenRefreshError(token);
  }

  try {
    const response = await fetch(refreshEndpoint, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        UserName: userName,
        RefreshToken: refreshToken,
        LanguageCode: languageCode,
      }),
      cache: "no-store",
    });

    const responseText = await response.text();
    const responseBody = parseJsonOrNull(responseText);

    if (!response.ok) {
      const responsePreview =
        responseText.length > 500 ? `${responseText.slice(0, 500)}...` : responseText;

      console.error("[auth][refresh] Refresh API failed", {
        endpoint: refreshEndpoint,
        status: response.status,
        statusText: response.statusText,
        body: responsePreview,
      });
      return getTokenRefreshError(token);
    }

    const refreshPayload = getRefreshTokenPayload(responseBody);
    if (!refreshPayload) {
      console.error("[auth][refresh] Cannot map refresh response", {
        endpoint: refreshEndpoint,
        body: responseBody,
      });
      return getTokenRefreshError(token);
    }

    return {
      ...token,
      accessToken: refreshPayload.Token,
      refreshToken: refreshPayload.RefreshToken,
      timeout: refreshPayload.Timeout || token.timeout,
      accessTokenExpiresAt: getJwtExp(refreshPayload.Token) ?? token.accessTokenExpiresAt,
      authError: undefined,
    };
  } catch (error) {
    console.error("[auth][refresh] Refresh API exception", {
      endpoint: refreshEndpoint,
      error,
    });
    return getTokenRefreshError(token);
  }
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
        device: { label: "Device", type: "text" },
      },
      authorize: async (credentials) => {
        const username = credentials?.username?.toString().trim();
        const password = credentials?.password?.toString();
        const device = credentials?.device?.toString() || "web";
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
              Device: device,
            }),
            cache: "no-store",
          });

          const responseText = await response.text();
          const responseBody = parseJsonOrNull(responseText);

          if (!response.ok) {
            const responsePreview =
              responseText.length > 500 ? `${responseText.slice(0, 500)}...` : responseText;

            console.error("[auth][credentials] Login API failed", {
              endpoint: loginEndpoint,
              status: response.status,
              statusText: response.statusText,
              body: responsePreview,
            });
            return null;
          }

          const loginPayload = getLoginPayload(responseBody);

          if (!loginPayload) {
            console.error("[auth][credentials] Cannot map login response", {
              endpoint: loginEndpoint,
              body: responseBody,
            });
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
        token.accessTokenExpiresAt =
          typeof user.accessToken === "string" ? (getJwtExp(user.accessToken) ?? undefined) : undefined;
        token.authError = undefined;
        return token;
      }

      const accessToken = asString(token.accessToken);
      if (accessToken && !isAccessTokenExpired(accessToken)) {
        return token;
      }

      if (asString(token.refreshToken)) {
        return refreshAccessToken(token);
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
      session.accessTokenExpiresAt =
        typeof token.accessTokenExpiresAt === "number" ? token.accessTokenExpiresAt : undefined;
      session.authError = typeof token.authError === "string" ? token.authError : undefined;

      return session;
    },
  },
});
