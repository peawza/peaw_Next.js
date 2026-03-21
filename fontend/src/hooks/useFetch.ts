"use client";

import axios, { type AxiosRequestConfig } from "axios";
import { useEffect, useState } from "react";
import axiosInstance from "@/lib/http/axios";

type UseFetchResult<T> = {
  data: T | null;
  loading: boolean;
  error: string | null;
};

export function useFetch<T>(url: string, config?: AxiosRequestConfig): UseFetchResult<T> {
  const [data, setData] = useState<T | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    let isMounted = true;
    const controller = new AbortController();

    axiosInstance
      .get<T>(url, { ...config, signal: controller.signal })
      .then((response) => {
        if (!isMounted) {
          return;
        }
        setData(response.data);
        setError(null);
      })
      .catch((requestError: unknown) => {
        if (axios.isCancel(requestError) || !isMounted) {
          return;
        }
        if (requestError instanceof Error) {
          setError(requestError.message);
          return;
        }
        setError("Request failed");
      })
      .finally(() => {
        if (isMounted) {
          setLoading(false);
        }
      });

    return () => {
      isMounted = false;
      controller.abort();
    };
  }, [url, config]);

  return { data, loading, error };
}
