function normalizeBase64Url(value: string): string {
  const base64 = value.replace(/-/g, "+").replace(/_/g, "/");
  const paddingLength = (4 - (base64.length % 4)) % 4;
  return base64 + "=".repeat(paddingLength);
}

function decodeBase64UrlToText(value: string): string | null {
  const normalized = normalizeBase64Url(value);

  try {
    if (typeof window === "undefined") {
      return Buffer.from(normalized, "base64").toString("utf-8");
    }

    const binary = window.atob(normalized);
    const bytes = Uint8Array.from(binary, (char) => char.charCodeAt(0));
    return new TextDecoder().decode(bytes);
  } catch {
    return null;
  }
}

function parseJwtPayload(token: string): Record<string, unknown> | null {
  const parts = token.split(".");
  if (parts.length < 2) {
    return null;
  }

  const payloadText = decodeBase64UrlToText(parts[1]);
  if (!payloadText) {
    return null;
  }

  try {
    const payload = JSON.parse(payloadText) as unknown;
    if (!payload || typeof payload !== "object" || Array.isArray(payload)) {
      return null;
    }
    return payload as Record<string, unknown>;
  } catch {
    return null;
  }
}

export function getJwtExp(token?: string | null): number | null {
  if (!token) {
    return null;
  }

  const payload = parseJwtPayload(token);
  if (!payload) {
    return null;
  }

  const exp = payload.exp;
  if (typeof exp === "number" && Number.isFinite(exp)) {
    return Math.trunc(exp);
  }
  if (typeof exp === "string") {
    const parsed = Number(exp);
    if (Number.isFinite(parsed)) {
      return Math.trunc(parsed);
    }
  }

  return null;
}

export function isAccessTokenExpired(
  token?: string | null,
  clockSkewSeconds = 10,
): boolean {
  if (!token) {
    return true;
  }

  const exp = getJwtExp(token);
  if (!exp) {
    return true;
  }

  const now = Math.floor(Date.now() / 1000);
  return exp <= now + clockSkewSeconds;
}
