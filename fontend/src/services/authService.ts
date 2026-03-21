import api from "@/services/api";
import type { AuthResponse, LoginPayload, RegisterPayload } from "@/types";

export const authService = {
  login: (payload: LoginPayload) => api.post<AuthResponse>("/auth/login", payload),
  register: (payload: RegisterPayload) => api.post<AuthResponse>("/auth/register", payload),
  me: () => api.get<AuthResponse["user"]>("/auth/me"),
  logout: () => api.post("/auth/logout"),
};
