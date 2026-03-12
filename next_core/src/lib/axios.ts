import axios from "axios";
import type { InternalAxiosRequestConfig } from "axios";
import { useLoadingStore } from "@/store";

type RequestConfigWithLoader = InternalAxiosRequestConfig & {
  _trackGlobalLoading?: boolean;
};

const axiosInstance = axios.create({
  baseURL: process.env.NEXT_PUBLIC_API_URL || "https://api.example.com",
  timeout: 10000,
  headers: {
    "Content-Type": "application/json",
  },
});

async function getAccessTokenFromSession(): Promise<string | null> {
  if (typeof window === "undefined") {
    return null;
  }

  const { getSession } = await import("next-auth/react");
  const session = await getSession();
  return session?.accessToken ?? null;
}

async function handleUnauthorized(): Promise<void> {
  if (typeof window === "undefined") {
    return;
  }

  const { signOut } = await import("next-auth/react");
  await signOut({ redirect: true, callbackUrl: "/login" });
}

axiosInstance.interceptors.request.use(
  async (config) => {
    const loadingConfig = config as RequestConfigWithLoader;
    const shouldTrackLoading = typeof window !== "undefined";
    loadingConfig._trackGlobalLoading = shouldTrackLoading;

    if (shouldTrackLoading) {
      useLoadingStore.getState().startLoading();
    }

    if (typeof window === "undefined") {
      return loadingConfig;
    }

    const token = await getAccessTokenFromSession();
    if (!token) {
      return loadingConfig;
    }

    loadingConfig.headers.set("Authorization", `Bearer ${token}`);
    return loadingConfig;
  },
  (error: unknown) => Promise.reject(error),
);

axiosInstance.interceptors.response.use(
  (response) => {
    const responseConfig = response.config as RequestConfigWithLoader;
    if (responseConfig._trackGlobalLoading) {
      useLoadingStore.getState().stopLoading();
    }

    return response;
  },
  async (error: unknown) => {
    if (axios.isAxiosError(error)) {
      const errorConfig = error.config as RequestConfigWithLoader | undefined;
      if (errorConfig?._trackGlobalLoading) {
        useLoadingStore.getState().stopLoading();
      }
    }

    if (
      typeof window !== "undefined" &&
      axios.isAxiosError(error) &&
      error.response?.status === 401
    ) {
      await handleUnauthorized();
    }

    return Promise.reject(error);
  },
);

export default axiosInstance;
