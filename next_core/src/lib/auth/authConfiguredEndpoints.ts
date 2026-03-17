import "server-only";

export const AUTH_PATH_FALLBACKS = {
  login: "/api/auth/SSS010/Login",
  refresh: "/api/auth/SSS010/RefreshToken",
  firstLogin: "/api/auth/SSS010/FirstLogin",
  otpSend: "/api/auth/otp/send-otp",
  otpVerify: "/api/auth/SSS010/otpverifylogin",
  otpResend: "/api/auth/otp/resend-otp",
} as const;

export function buildConfiguredApiEndpoint(
  path: string | undefined,
  fallbackPath: string,
): string | null {
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

export function getConfiguredAuthEndpoints() {
  return {
    login: buildConfiguredApiEndpoint(process.env.AUTH_LOGIN_PATH, AUTH_PATH_FALLBACKS.login),
    refresh: buildConfiguredApiEndpoint(process.env.AUTH_REFRESH_PATH, AUTH_PATH_FALLBACKS.refresh),
    firstLogin: buildConfiguredApiEndpoint(
      process.env.AUTH_FIRST_LOGIN_PATH,
      AUTH_PATH_FALLBACKS.firstLogin,
    ),
    otpSend: buildConfiguredApiEndpoint(process.env.AUTH_OTP_SEND_PATH, AUTH_PATH_FALLBACKS.otpSend),
    otpVerify: buildConfiguredApiEndpoint(
      process.env.AUTH_OTP_VERIFY_PATH,
      AUTH_PATH_FALLBACKS.otpVerify,
    ),
    otpResend: buildConfiguredApiEndpoint(
      process.env.AUTH_OTP_RESEND_PATH,
      AUTH_PATH_FALLBACKS.otpResend,
    ),
  };
}
