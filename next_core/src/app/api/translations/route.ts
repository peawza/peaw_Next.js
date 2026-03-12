import { NextResponse } from "next/server";
import { auth } from "@/auth";
import { loadSystemResources } from "@/services/resourceService.server";

function toCustomerId(value: unknown): string {
  if (value === null || value === undefined) {
    return "";
  }
  return String(value).trim();
}

export async function GET(request: Request) {
  const session = await auth();
  const { searchParams } = new URL(request.url);

  const queryCustomerId = toCustomerId(searchParams.get("customerId"));
  const sessionCustomerId = toCustomerId(session?.customerId);
  const customerId = queryCustomerId || sessionCustomerId;

  const resources = await loadSystemResources(customerId, {
    accessToken: session?.accessToken,
  });

  return NextResponse.json(resources);
}
