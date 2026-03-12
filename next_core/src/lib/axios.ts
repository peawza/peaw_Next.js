import axios from "axios";

const axiosInstance = axios.create({
  baseURL: process.env.NEXT_PUBLIC_API_URL || "https://api.example.com",
  timeout: 10000,
  headers: {
    "Content-Type": "application/json",
  },
});

axiosInstance.interceptors.request.use(
  (config) => {
    if (typeof window === "undefined") {
      return config;
    }

    const token = window.localStorage.getItem("token");
    if (!token) {
      return config;
    }

    config.headers.set("Authorization", `Bearer ${token}`);
    return config;
  },
  (error: unknown) => Promise.reject(error),
);

axiosInstance.interceptors.response.use(
  (response) => response,
  (error: unknown) => {
    if (
      typeof window !== "undefined" &&
      axios.isAxiosError(error) &&
      error.response?.status === 401
    ) {
      window.location.href = "/login";
    }

    return Promise.reject(error);
  },
);

export default axiosInstance;
