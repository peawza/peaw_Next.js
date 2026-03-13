import { NextResponse } from "next/server";
import {
  asString,
  hasDirectLoginPayload,
  isBackendExceptionPayload,
  parseJsonOrNull,
  readBooleanByKeys,
  readErrorMessage,
  readStringByKeys,
} from "@/lib/authRequest";

type PreLoginRequestBody = {
  UserName?: string;
  Password?: string;
  Device?: string;
};

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
  const loginEndpoint = buildApiEndpoint(process.env.AUTH_LOGIN_PATH, "/api/auth/SSS010/Login");
  const sendOtpEndpoint = buildApiEndpoint(process.env.AUTH_OTP_SEND_PATH, "/api/auth/otp/send-otp");

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

    if (isBackendExceptionPayload(responseBody)) {
      return NextResponse.json(
        {
          status: "error",
          message: readErrorMessage(responseBody) ?? "Login API returned backend exception",
          payload: responseBody,
        },
        { status: 400 },
      );
    }

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

      if (isBackendExceptionPayload(sendOtpPayload)) {
        return NextResponse.json(
          {
            status: "error",
            message: readErrorMessage(sendOtpPayload) ?? "OTP send API returned backend exception",
            payload: sendOtpPayload,
          },
          { status: 400 },
        );
      }

      const sendOtpSuccess =
        readBooleanByKeys(sendOtpPayload, ["resultStatus", "ResultStatus", "Success"]) !== false;

      if (!sendOtpSuccess) {
        return NextResponse.json(
          {
            status: "error",
            message: readErrorMessage(sendOtpPayload) ?? "Login send-otp returned unsuccessful status",
            payload: sendOtpPayload,
          },
          { status: 400 },
        );
      }

      const otpToken =
        readStringByKeys(sendOtpPayload, ["Token", "token", "OtpToken", "VerifyToken"]) ?? token;

      if (!otpToken) {
        return NextResponse.json(
          {
            status: "error",
            message: "OTP verification is required but token is missing",
            payload: sendOtpPayload,
          },
          { status: 400 },
        );
      }

      return NextResponse.json({
        status: "verify_login_required",
        token: otpToken,
        username: asString(readStringByKeys(responseBody, ["UserName", "userName"])) ?? userName,
        payload: sendOtpPayload,
        loginPayload: responseBody,
      });
    }

    if (firstLogin) {
      if (!token) {
        return NextResponse.json(
          {
            status: "error",
            message: "First login is required but token is missing",
            payload: responseBody,
          },
          { status: 400 },
        );
      }

      return NextResponse.json({
        status: "first_login_required",
        token,
        username: asString(readStringByKeys(responseBody, ["UserName", "userName"])) ?? userName,
        payload: responseBody,
      });
    }

    if (!hasDirectLoginPayload(responseBody)) {
      return NextResponse.json(
        {
          status: "error",
          message: readErrorMessage(responseBody) ?? "Login API did not return a usable login payload",
          payload: responseBody,
        },
        { status: 400 },
      );
    }

    return NextResponse.json({
      status: "success",
      payload: responseBody,
      username: asString(readStringByKeys(responseBody, ["UserName", "userName"])) ?? userName,
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
