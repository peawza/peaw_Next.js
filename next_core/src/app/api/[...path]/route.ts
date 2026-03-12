import { NextResponse } from "next/server";

type RouteContext = {
  params: Promise<{ path: string[] }>;
};

export async function GET(_request: Request, context: RouteContext) {
  const { path } = await context.params;

  return NextResponse.json({
    message: "API catch-all route is ready",
    path,
  });
}
