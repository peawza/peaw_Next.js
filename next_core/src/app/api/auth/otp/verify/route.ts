import { NextResponse } from "next/server";

type OtpVerifyRequestBody = {
  Token?: string;
  OtpCode?: string;
  Device?: string;
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

export async function POST(request: Request) {
  const endpoint = buildApiEndpoint(process.env.AUTH_OTP_VERIFY_PATH, "/SSS010/otpverifylogin");

  if (!endpoint) {
    return NextResponse.json(
      { status: "error", message: "AUTH_API_URL is not configured" },
      { status: 500 },
    );
  }

  const body = (await request.json()) as OtpVerifyRequestBody;
  const token = body.Token?.trim();
  const otpCode = body.OtpCode?.trim();
  const device = body.Device || "web";

  if (!token || !otpCode) {
    return NextResponse.json(
      { status: "error", message: "Token and OtpCode are required" },
      { status: 400 },
    );
  }

  try {
    const response = await fetch(endpoint, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        Token: token,
        OtpCode: otpCode,
        Device: device,
      }),
      cache: "no-store",
    });

    const responseText = await response.text();
    const responseBody = parseJsonOrNull(responseText) ?? responseText;

    if (!response.ok) {
      return NextResponse.json(
        {
          status: "error",
          message: "OTP verify request failed",
          httpStatus: response.status,
          payload: responseBody,
        },
        { status: response.status },
      );
    }

    return NextResponse.json({
      status: "success",
      payload: responseBody,
    });
  } catch (error) {
    return NextResponse.json(
      {
        status: "error",
        message: "Cannot call OTP verify API",
        error: error instanceof Error ? error.message : String(error),
      },
      { status: 500 },
    );
  }
}
