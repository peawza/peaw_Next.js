import { NextResponse } from "next/server";

type PreLoginRequestBody = {
  UserName?: string;
  Password?: string;
  Device?: string;
};

function asString(value: unknown): string | null {
  if (typeof value === "string" && value.trim() !== "") {
    return value;
  }
  if (typeof value === "number" && Number.isFinite(value)) {
    return String(value);
  }
  return null;
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

type RequestErrorResult = {
  status: "error";
  message: string;
  httpStatus: number;
  payload: unknown;
};

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

function readBooleanByKeys(input: unknown, keys: string[], depth = 0): boolean | null {
  if (depth > 6 || input == null) {
    return null;
  }

  if (typeof input === "boolean") {
    return input;
  }

  if (typeof input !== "object") {
    return null;
  }

  if (Array.isArray(input)) {
    for (const item of input) {
      const result = readBooleanByKeys(item, keys, depth + 1);
      if (result != null) {
        return result;
      }
    }
    return null;
  }

  const record = input as Record<string, unknown>;

  for (const key of keys) {
    const value = record[key];
    if (typeof value === "boolean") {
      return value;
    }
    if (typeof value === "string") {
      const normalized = value.trim().toLowerCase();
      if (normalized === "true") {
        return true;
      }
      if (normalized === "false") {
        return false;
      }
    }
  }

  for (const value of Object.values(record)) {
    const result = readBooleanByKeys(value, keys, depth + 1);
    if (result != null) {
      return result;
    }
  }

  return null;
}

function readStringByKeys(input: unknown, keys: string[], depth = 0): string | null {
  if (depth > 6 || input == null) {
    return null;
  }

  const direct = asString(input);
  if (direct && depth > 0) {
    return direct;
  }

  if (typeof input !== "object") {
    return null;
  }

  if (Array.isArray(input)) {
    for (const item of input) {
      const result = readStringByKeys(item, keys, depth + 1);
      if (result) {
        return result;
      }
    }
    return null;
  }

  const record = input as Record<string, unknown>;

  for (const key of keys) {
    const value = asString(record[key]);
    if (value) {
      return value;
    }
  }

  for (const value of Object.values(record)) {
    const result = readStringByKeys(value, keys, depth + 1);
    if (result) {
      return result;
    }
  }

  return null;
}

async function callJsonApi(endpoint: string, payload: Record<string, unknown>) {
  const response = await fetch(endpoint, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(payload),
    cache: "no-store",
  });

  const responseText = await response.text();
  const responseBody = parseJsonOrNull(responseText) ?? responseText;

  if (!response.ok) {
    const result: RequestErrorResult = {
      status: "error",
      message: "Request failed",
      httpStatus: response.status,
      payload: responseBody,
    };
    return result;
  }

  return {
    status: "success" as const,
    payload: responseBody,
  };
}

export async function POST(request: Request) {
  const loginEndpoint = buildApiEndpoint(process.env.AUTH_LOGIN_PATH, "/SSS010/Login");
  const sendOtpEndpoint = buildApiEndpoint(process.env.AUTH_OTP_SEND_PATH, "/otp/send-otp");
  if (!loginEndpoint) {
    return NextResponse.json(
      {
        status: "error",
        message: "AUTH_API_URL is not configured",
      },
      { status: 500 },
    );
  }

  const body = (await request.json()) as PreLoginRequestBody;
  const userName = body.UserName?.trim();
  const password = body.Password;
  const device = body.Device || "web";

  if (!userName || !password) {
    return NextResponse.json(
      {
        status: "error",
        message: "UserName and Password are required",
      },
      { status: 400 },
    );
  }

  try {
    const loginResult = await callJsonApi(loginEndpoint, {
      UserName: userName,
      Password: password,
      Device: device,
    });

    if (loginResult.status === "error") {
      return NextResponse.json(
        {
          ...loginResult,
          message: "Login request failed",
        },
        { status: loginResult.httpStatus },
      );
    }

    const responseBody = loginResult.payload;
    const verifyLogin =
      readBooleanByKeys(responseBody, ["VerifyLogin", "verifyLogin", "OtpRequired"]) === true;
    const firstLogin =
      readBooleanByKeys(responseBody, [
        "FirstLogin",
        "firstLogin",
        "IsFirstLogin",
        "NeedChangePassword",
        "ForceChangePassword",
      ]) === true;

    const token = readStringByKeys(responseBody, ["Token", "token", "VerifyToken", "OtpToken"]);

    if (verifyLogin) {
      if (!sendOtpEndpoint) {
        return NextResponse.json(
          {
            status: "error",
            message: "AUTH_OTP_SEND_PATH is not configured",
          },
          { status: 500 },
        );
      }

      const sendOtpResult = await callJsonApi(sendOtpEndpoint, {
        UserName: userName,
        Channel: device,
      });

      if (sendOtpResult.status === "error") {
        return NextResponse.json(
          {
            ...sendOtpResult,
            message: "Login send-otp request failed",
          },
          { status: sendOtpResult.httpStatus },
        );
      }

      const sendOtpPayload = sendOtpResult.payload;
      const sendOtpSuccess =
        readBooleanByKeys(sendOtpPayload, ["resultStatus", "ResultStatus", "Success"]) !== false;

      if (!sendOtpSuccess) {
        return NextResponse.json(
          {
            status: "error",
            message: "Login send-otp returned unsuccessful status",
            payload: sendOtpPayload,
          },
          { status: 400 },
        );
      }

      const otpToken =
        readStringByKeys(sendOtpPayload, ["Token", "token", "OtpToken", "VerifyToken"]) ?? token;

      return NextResponse.json({
        status: "verify_login_required",
        token: otpToken,
        username: userName,
        payload: sendOtpPayload,
        loginPayload: responseBody,
      });
    }

    if (firstLogin) {
      return NextResponse.json({
        status: "first_login_required",
        token,
        username: userName,
        payload: responseBody,
      });
    }

    return NextResponse.json({
      status: "success",
      payload: responseBody,
      username: userName,
    });
  } catch (error) {
    return NextResponse.json(
      {
        status: "error",
        message: "Cannot call login API",
        error: error instanceof Error ? error.message : String(error),
      },
      { status: 500 },
    );
  }
}
