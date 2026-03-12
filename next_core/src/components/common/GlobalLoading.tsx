"use client";

import { useLoadingStore } from "@/store/loadingStore";

export default function GlobalLoading() {
  const isLoading = useLoadingStore((state) => state.isLoading);

  if (!isLoading) return null;

  return (
    <>
      {/* Top progress bar */}
      <div className="fixed top-0 left-0 z-9999 h-1 w-full overflow-hidden bg-transparent">
        <div className="animate-progress h-full bg-blue-500" />
      </div>

      {/* Full screen overlay (optional) */}
      <div className="fixed inset-0 z-9998 flex items-center justify-center bg-black/20">
        <div className="flex flex-col items-center gap-3 rounded-xl bg-white px-8 py-6 shadow-lg">
          <div className="h-10 w-10 animate-spin rounded-full border-4 border-blue-500 border-t-transparent" />
          <span className="text-sm text-gray-500">กำลังโหลด...</span>
        </div>
      </div>
    </>
  );
}

