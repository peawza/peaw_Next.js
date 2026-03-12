import axios, {
  AxiosRequestConfig,
  AxiosResponse,
  InternalAxiosRequestConfig,
} from "axios";
import { useLoadingStore } from "@/store/loadingStore";
import { format } from "date-fns";

// ─────────────────────────────────────────────
// ⚙️ Constants
// ─────────────────────────────────────────────
const API_TIMEOUT    = 3600 * 1000;
const TEXT_API_ERROR = "Could not connect the internet. Please contact IT support.";
const COOKIE_ACCESS  = process.env.NEXT_PUBLIC_COOKIE_ACCESS  ?? "next-access-token";
const COOKIE_REFRESH = process.env.NEXT_PUBLIC_COOKIE_REFRESH ?? "next-refresh-token";

// ─────────────────────────────────────────────
// 🍪 Cookie Helpers
// ─────────────────────────────────────────────
export function getAccessToken(): string | null {
  if (typeof document === "undefined") return null;

  const name    = `${COOKIE_ACCESS}=`;
  const cookies = decodeURIComponent(document.cookie).split(";");

  for (const cookie of cookies) {
    const c = cookie.trim();
    if (c.startsWith(name)) return c.substring(name.length);
  }
  return null;
}

export function getRefreshToken(): string | null {
  if (typeof document === "undefined") return null;

  const name    = `${COOKIE_REFRESH}=`;
  const cookies = decodeURIComponent(document.cookie).split(";");

  for (const cookie of cookies) {
    const c = cookie.trim();
    if (c.startsWith(name)) return c.substring(name.length);
  }
  return null;
}

// ─────────────────────────────────────────────
// 📅 Date Transformers
// ─────────────────────────────────────────────
const DATE_TIME_REGEX = /^\d{4}-\d{2}-\d{2}[T\s]\d{2}:\d{2}:\d{2}(\.\d+)?([+-]\d{2}:\d{2})?$/;

/** แปลง local time → UTC ก่อนส่งไป API */
function convertLocalTimeToUTC(data: unknown): unknown {
  if (Array.isArray(data)) {
    return data.map(convertLocalTimeToUTC);
  }

  if (data instanceof Date) {
    return new Date(data.getTime() - data.getTimezoneOffset() * 60000);
  }

  if (typeof data === "object" && data !== null) {
    return Object.fromEntries(
      Object.entries(data as Record<string, unknown>).map(([key, value]) => [
        key,
        convertLocalTimeToUTC(value),
      ]),
    );
  }

  if (typeof data === "string" && DATE_TIME_REGEX.test(data)) {
    const localDate = new Date(data);
    const utcDate   = new Date(localDate.getTime() - localDate.getTimezoneOffset() * 60000);
    return utcDate.toISOString();
  }

  return data;
}

/** Transform ข้อมูลก่อนส่ง — แปลง Date → UTC string สำหรับ API */
export function dateTransformer(data: unknown): unknown {
  if (data === "") return null;

  if (data instanceof Date || (typeof data === "string" && DATE_TIME_REGEX.test(data))) {
    const utc = convertLocalTimeToUTC(data) as Date | string;
    const d   = utc instanceof Date ? utc : new Date(utc);
    return format(d, "MM/dd/yyyy HH:mm:ss.SSSSSS");
  }

  if (Array.isArray(data)) return data.map(dateTransformer);

  if (typeof data === "object" && data !== null) {
    return Object.fromEntries(
      Object.entries(data as Record<string, unknown>).map(([key, value]) => [
        key,
        dateTransformer(value),
      ]),
    );
  }

  return data;
}

/** แปลง UTC response → Local time */
export function convertDatesToLocalTime<T>(data: T): T {
  const OFFSET_HOURS  = -new Date().getTimezoneOffset() / 60;
  const LOCAL_DT_REGEX = /^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}(\.\d+)?$/;

  if (Array.isArray(data)) {
    return data.map((item) => convertDatesToLocalTime(item)) as T;
  }

  if (typeof data === "object" && data !== null) {
    const result = { ...(data as Record<string, unknown>) };

    for (const key of Object.keys(result)) {
      const value = result[key];

      if (typeof value === "string" && LOCAL_DT_REGEX.test(value)) {
        const date = new Date(value);
        date.setHours(date.getHours() + OFFSET_HOURS);
        result[key] = date;
      } else if (typeof value === "object" && value !== null) {
        result[key] = convertDatesToLocalTime(value);
      }
    }

    return result as T;
  }

  return data;
}

// ─────────────────────────────────────────────
// 📎 FormData Helper
// ─────────────────────────────────────────────
export function objectToFormData(obj: Record<string, unknown>): FormData {
  const formData = new FormData();

  for (const [key, value] of Object.entries(obj)) {
    if (value === "" || value == null) continue;

    if (value instanceof Date) {
      formData.append(key, format(value, "MM/dd/yyyy HH:mm:ss"));
      continue;
    }

    if (Array.isArray(value)) {
      if (value.length === 0) continue;

      // กรณีพิเศษ Files → แตกเป็นหลาย field
      if (key === "Files") {
        value.forEach((item, index) => {
          const file =
            item instanceof File || item instanceof Blob
              ? item
              : item?.fileRaw instanceof File
                ? item.fileRaw
                : null;

          if (file) {
            formData.append(key, file, (file as File).name || `file_${index}`);
          }
        });
      } else {
        value.forEach((item) => {
          if (item === "" || item == null) return;
          if (item instanceof Date) {
            formData.append(key, format(item, "MM/dd/yyyy HH:mm:ss"));
          } else {
            formData.append(key, item as string);
          }
        });
      }
      continue;
    }

    formData.append(key, value as string);
  }

  return formData;
}

// ─────────────────────────────────────────────
// 🔧 Axios Instance
// ─────────────────────────────────────────────
const axiosInstance = axios.create({
  baseURL: process.env.NEXT_PUBLIC_API_URL || "",
  timeout: API_TIMEOUT,
  headers: { "Content-Type": "application/json" },
});

// Request interceptor — attach token + loading
axiosInstance.interceptors.request.use(
  (config: InternalAxiosRequestConfig) => {
    useLoadingStore.getState().startLoading();

    const token = getAccessToken();
    if (token) config.headers.set("Authorization", `Bearer ${token}`);

    return config;
  },
  (error: unknown) => {
    useLoadingStore.getState().stopLoading();
    return Promise.reject(error);
  },
);

// Response interceptor — stop loading + 401 redirect
axiosInstance.interceptors.response.use(
  (response: AxiosResponse) => {
    useLoadingStore.getState().stopLoading();
    return response;
  },
  (error: unknown) => {
    useLoadingStore.getState().stopLoading();

    if (
      typeof window !== "undefined" &&
      axios.isAxiosError(error) &&
      error.response?.status === 401
    ) {
      window.location.href = "/Account/Logout";
    }

    return Promise.reject(error);
  },
);

// ─────────────────────────────────────────────
// 🌐 Base Config
// ─────────────────────────────────────────────
const baseConfig: AxiosRequestConfig = {
  timeout:        API_TIMEOUT,
  maxRedirects:   0,
  validateStatus: (status) => status >= 200 && status < 400,
};

/** ตรวจสอบ HTML redirect (session หมดอายุ) */
function checkHtmlRedirect(response: AxiosResponse): void {
  const contentType = response.headers["content-type"] ?? "";
  if (contentType === "text/html; charset=utf-8" && typeof window !== "undefined") {
    window.location.href = response.request?.responseURL || "/";
  }
}

/** จัดการ error กลาง */
function handleApiError(error: unknown, fnName: string): never {
  if (axios.isAxiosError(error) && error.response?.status === 401) {
    if (typeof window !== "undefined") {
      window.location.href = "/Account/Logout";
    }
  }

  console.error(`[${fnName}] Error:`, axios.isAxiosError(error) ? error.message : error);

  // แสดง error notification — เชื่อมกับ toast ที่ใช้ในโปรเจ็ค
  // toast.error(TEXT_API_ERROR);

  throw new TypeError(axios.isAxiosError(error) ? error.message : TEXT_API_ERROR);
}

// ─────────────────────────────────────────────
// 📡 API Functions
// ─────────────────────────────────────────────

/** GET — ดึงข้อมูลทั่วไป */
export async function APIGet<T = unknown>(
  url: string,
  params?: Record<string, unknown>,
): Promise<T> {
  try {
    const response = await axiosInstance.get<T>(url, {
      ...baseConfig,
      params: params ? dateTransformer(params) : undefined,
    });

    checkHtmlRedirect(response);
    return convertDatesToLocalTime(response.data);
  } catch (error) {
    return handleApiError(error, "APIGet");
  }
}

/** POST — ส่งข้อมูลทั่วไป */
export async function APIPost<T = unknown>(
  url: string,
  data?: unknown,
): Promise<T> {
  try {
    const response = await axiosInstance.post<T>(
      url,
      data ? dateTransformer(data) : undefined,
      baseConfig,
    );

    checkHtmlRedirect(response);
    return convertDatesToLocalTime(response.data);
  } catch (error) {
    return handleApiError(error, "APIPost");
  }
}

/** GET — ดาวน์โหลดไฟล์ */
export async function APIGetFile(
  url: string,
  fileName: string,
  params?: Record<string, unknown>,
): Promise<void> {
  try {
    const response = await axiosInstance.get(url, {
      ...baseConfig,
      params:       params ? dateTransformer(params) : undefined,
      responseType: "blob",
    });

    const contentType = response.headers["content-type"] ?? "";
    if (contentType.startsWith("text/html") && typeof window !== "undefined") {
      window.location.href = response.request?.responseURL || "/";
      return;
    }

    triggerDownload(response.data as Blob, fileName);
  } catch (error) {
    return handleApiError(error, "APIGetFile");
  }
}

/** POST — ดาวน์โหลดไฟล์ (ส่ง criteria ไปด้วย) */
export async function APIPostDownloadFile(
  url: string,
  data: unknown,
  fileName: string,
): Promise<void> {
  try {
    const response = await axiosInstance.post(
      url,
      data ? dateTransformer(data) : undefined,
      { ...baseConfig, responseType: "blob" },
    );

    const contentType = (response.headers["content-type"] ?? "").toLowerCase();
    if (contentType.startsWith("text/html") && typeof window !== "undefined") {
      window.location.href = response.request?.responseURL || "/";
      return;
    }

    // ดึง filename จาก header ถ้ามี
    const cd          = response.headers["content-disposition"] ?? "";
    const match       = cd.match(/filename\*=UTF-8''(.+)|filename="?([^"]+)"?/i);
    const finalName   = fileName
      ? `${fileName}.xlsx`
      : decodeURIComponent(match?.[1] || match?.[2] || "download.xlsx");

    triggerDownload(response.data as Blob, finalName);
  } catch (error) {
    return handleApiError(error, "APIPostDownloadFile");
  }
}

/** POST — upload ไฟล์พร้อม data (multipart/form-data) */
export async function APIPostUploadFile<T = unknown>(
  url: string,
  data: Record<string, unknown>,
): Promise<T> {
  try {
    const response = await axiosInstance.post<T>(url, objectToFormData(data), {
      ...baseConfig,
      headers: { "Content-Type": "multipart/form-data" },
    });

    checkHtmlRedirect(response);
    return response.data;
  } catch (error) {
    return handleApiError(error, "APIPostUploadFile");
  }
}

/** POST — upload ไฟล์เดี่ยว (raw file) */
export async function APIPostUploadFileRaw<T = unknown>(
  url: string,
  file: File | Blob,
): Promise<T> {
  try {
    const formData = new FormData();
    formData.append("file", file);

    const response = await axiosInstance.post<T>(url, formData, {
      ...baseConfig,
      headers: { "Content-Type": "multipart/form-data" },
    });

    checkHtmlRedirect(response);
    return response.data;
  } catch (error) {
    return handleApiError(error, "APIPostUploadFileRaw");
  }
}

// ─────────────────────────────────────────────
// 🔄 Token Auto Refresh
// ─────────────────────────────────────────────

/**
 * @param tokenTimeoutMinutes - อายุ token (นาที) จาก server
 * @param languageCode        - ภาษาปัจจุบัน
 */
export function autoRefreshToken(
  tokenTimeoutMinutes: number,
  languageCode: string,
): void {
  // refresh ก่อน token หมด 5 นาที
  const intervalMs = (tokenTimeoutMinutes - 5) * 60 * 1000;

  async function refresh(): Promise<void> {
    const refreshToken = getRefreshToken();
    if (!refreshToken) return;

    try {
      const response = await APIPost<{ status: string }>("/refresh/token", {
        RefreshToken: refreshToken,
        LanguageCode: languageCode,
      });

      if (response.status !== "OK") {
        if (typeof window !== "undefined") {
          window.location.href = "/Account/Logout";
        }
        return;
      }

      console.log("[autoRefreshToken] Token refreshed ✅");
      setTimeout(refresh, intervalMs); // ← ตั้งรอบถัดไป
    } catch (error) {
      console.error("[autoRefreshToken] Error:", error);
    }
  }

  setTimeout(refresh, intervalMs);
}

// ─────────────────────────────────────────────
// 🛠️ Private Helpers
// ─────────────────────────────────────────────

/** สร้าง link ดาวน์โหลดและ trigger click */
function triggerDownload(blob: Blob, fileName: string): void {
  if (typeof window === "undefined") return;

  const url = window.URL.createObjectURL(blob);
  const a   = document.createElement("a");

  a.href     = url;
  a.download = fileName;
  document.body.appendChild(a);
  a.click();
  a.remove();

  window.URL.revokeObjectURL(url);
}

export default axiosInstance;