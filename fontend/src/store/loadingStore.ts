import { create } from "zustand";

type LoadingStore = {
  pendingRequests: number;
  isLoading: boolean;
  startLoading: () => void;
  stopLoading: () => void;
  resetLoading: () => void;
};

export const useLoadingStore = create<LoadingStore>((set) => ({
  pendingRequests: 0,
  isLoading: false,
  startLoading: () =>
    set((state) => {
      const pendingRequests = state.pendingRequests + 1;
      return {
        pendingRequests,
        isLoading: pendingRequests > 0,
      };
    }),
  stopLoading: () =>
    set((state) => {
      const pendingRequests = Math.max(0, state.pendingRequests - 1);
      return {
        pendingRequests,
        isLoading: pendingRequests > 0,
      };
    }),
  resetLoading: () =>
    set({
      pendingRequests: 0,
      isLoading: false,
    }),
}));
