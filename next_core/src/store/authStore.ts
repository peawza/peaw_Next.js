import { create } from "zustand";
import type { AuthState, AuthUser } from "@/types";

type AuthStore = AuthState & {
  login: (user: AuthUser, token: string) => void;
  logout: () => void;
};

const initialState: AuthState = {
  user: null,
  token: null,
  isAuthenticated: false,
};

export const useAuthStore = create<AuthStore>((set) => ({
  ...initialState,
  login: (user, token) =>
    set({
      user,
      token,
      isAuthenticated: true,
    }),
  logout: () => set(initialState),
}));
