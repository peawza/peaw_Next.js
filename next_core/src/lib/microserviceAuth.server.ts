import "server-only";

import { createHmac } from "node:crypto";
import { cookies } from "next/headers";

type CachedToken = {
  token: string;
  expiresAt: number;
};

let cachedServiceToken: CachedToken | null = null;

const TOKEN_CACHE_SKEW_MS = 5 * 60 * 1000;
const DEFAULT_EXPIRE_MINUTES = 60;

function asNonEmptyString(value: unknown): string | null {
  return typeof value === "string" && value.trim() !== "" ? value.trim() : null;
}

function readEnv(...keys: string[]): string | null {
  for (const key of keys) {
    const value = asNonEmptyString(process.env[key]);
    if (value) {
      return value;
    }
  }
  return null;
}

function readExpireMinutes(): number {
  const rawValue = readEnv("JWT_EXPIRE_MINUTES", "JwtExpireMinutes");
  if (!rawValue) {
    return DEFAULT_EXPIRE_MINUTES;
  }

  const parsed = Number(rawValue);
  if (Number.isFinite(parsed) && parsed > 0) {
    return parsed;
  }

  return DEFAULT_EXPIRE_MINUTES;
}

function encodeBase64Url(input: string): string {
  return Buffer.from(input, "utf8").toString("base64url");
}

function createHs256Jwt(payload: Record<string, unknown>, secret: string): string {
  const header = {
    alg: "HS256",
    typ: "JWT",
  };

  const encodedHeader = encodeBase64Url(JSON.stringify(header));
  const encodedPayload = encodeBase64Url(JSON.stringify(payload));
  const unsignedToken = `${encodedHeader}.${encodedPayload}`;
  const signature = createHmac("sha256", secret).update(unsignedToken).digest("base64url");

  return `${unsignedToken}.${signature}`;
}

function createServiceToken(): CachedToken | null {
  const jwtKey = readEnv("JWT_KEY", "JwtKey");
  const jwtIssuer = readEnv("JWT_ISSUER", "JwtIssuer");

  if (!jwtKey || !jwtIssuer) {
    return null;
  }

  const expireMinutes = readExpireMinutes();
  const nowInSeconds = Math.floor(Date.now() / 1000);
  const expiresAt = nowInSeconds + expireMinutes * 60;

  const token = createHs256Jwt(
    {
      iss: jwtIssuer,
      aud: jwtIssuer,
      iat: nowInSeconds,
      exp: expiresAt,
      typeService: "micoService",
    },
    jwtKey,
  );

  return {
    token,
    expiresAt: expiresAt * 1000,
  };
}

function isCachedTokenValid(cachedToken: CachedToken): boolean {
  return Date.now() < cachedToken.expiresAt - TOKEN_CACHE_SKEW_MS;
}

async function readAccessTokenFromCookies(): Promise<string | null> {
  try {
    const cookieStore = await cookies();
    const candidateCookieNames = [
      readEnv("NEXT_PUBLIC_COOKIE_ACCESS"),
      "next-access-token",
    ].filter((name): name is string => Boolean(name));

    for (const cookieName of candidateCookieNames) {
      const cookieValue = cookieStore.get(cookieName)?.value;
      const resolvedValue = asNonEmptyString(cookieValue);
      if (resolvedValue) {
        return resolvedValue;
      }
    }
  } catch {
    // Ignore when cookies are unavailable (outside request scope).
  }

  return null;
}

export async function resolveBackendAuthToken(
  preferredToken?: string | null,
): Promise<string | null> {
  const fromPreferred = asNonEmptyString(preferredToken);
  if (fromPreferred) {
    return fromPreferred;
  }

  const fromCookie = await readAccessTokenFromCookies();
  if (fromCookie) {
    return fromCookie;
  }

  if (cachedServiceToken && isCachedTokenValid(cachedServiceToken)) {
    return cachedServiceToken.token;
  }

  const generatedToken = createServiceToken();
  if (!generatedToken) {
    return null;
  }

  cachedServiceToken = generatedToken;
  return generatedToken.token;
}
