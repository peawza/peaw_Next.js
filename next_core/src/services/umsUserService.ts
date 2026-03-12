import { APIPostWithToken } from "@/lib/apiClient";
import type {
  UmsChangePasswordRequest,
  UmsChangePasswordResponse,
  UmsGetUserByIdResponse,
} from "@/types";

function buildApiEndpoint(path: string): string {
  if (/^https?:\/\//i.test(path)) {
    return path;
  }

  const baseUrl = process.env.NEXT_PUBLIC_API_URL?.trim();
  if (!baseUrl) {
    return path;
  }

  const normalizedBaseUrl = baseUrl.endsWith("/") ? baseUrl.slice(0, -1) : baseUrl;
  const normalizedPath = path.startsWith("/") ? path : `/${path}`;
  return `${normalizedBaseUrl}${normalizedPath}`;
}

const UMS_GET_BY_ID_PATH =
  process.env.NEXT_PUBLIC_UMS_GET_BY_ID_PATH ?? "/api/auth/ums010/getby/id";
const UMS_CHANGE_PASSWORD_PATH =
  process.env.NEXT_PUBLIC_UMS_CHANGE_PASSWORD_PATH ?? "/api/auth/ums010/change/password";

export async function getUmsUserById(
  userId: string,
  accessToken: string,
): Promise<UmsGetUserByIdResponse> {
  return APIPostWithToken<UmsGetUserByIdResponse>(
    buildApiEndpoint(UMS_GET_BY_ID_PATH),
    {
      UserId: userId,
    },
    accessToken,
  );
}

export async function changeUmsPassword(
  payload: UmsChangePasswordRequest,
  accessToken: string,
): Promise<UmsChangePasswordResponse> {
  return APIPostWithToken<UmsChangePasswordResponse>(
    buildApiEndpoint(UMS_CHANGE_PASSWORD_PATH),
    payload,
    accessToken,
  );
}
