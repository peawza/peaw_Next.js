import { NextResponse } from "next/server";

type OtpSendRequestBody = {
  UserName?: string;
  Channel?: string;
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
  const endpoint = buildApiEndpoint(process.env.AUTH_OTP_SEND_PATH, "/otp/send-otp");

  if (!endpoint) {
    return NextResponse.json(
      { status: "error", message: "AUTH_API_URL is not configured" },
      { status: 500 },
    );
  }

  const body = (await request.json()) as OtpSendRequestBody;
  const userName = body.UserName?.trim();
  const channel = body.Channel || "web";

  if (!userName) {
    return NextResponse.json(
      { status: "error", message: "UserName is required" },
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
        UserName: userName,
        Channel: channel,
      }),
      cache: "no-store",
    });

    const responseText = await response.text();
    const responseBody = parseJsonOrNull(responseText) ?? responseText;

    if (!response.ok) {
      return NextResponse.json(
        {
          status: "error",
          message: "OTP send request failed",
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
        message: "Cannot call OTP send API",
        error: error instanceof Error ? error.message : String(error),
      },
      { status: 500 },
    );
  }
}
