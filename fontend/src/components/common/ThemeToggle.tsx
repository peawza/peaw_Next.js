"use client";

import { useTheme } from "@/providers/ThemeProvider";

export function ThemeToggle() {
  const { toggleTheme } = useTheme();

  return (
    <button
      type="button"
      onClick={toggleTheme}
      className="inline-flex items-center gap-2 rounded-md border border-slate-200 bg-white px-2 py-1 text-xs font-semibold text-slate-700 transition hover:bg-slate-100 dark:border-slate-700 dark:bg-slate-800 dark:text-slate-200 dark:hover:bg-slate-700"
      title="Toggle theme"
      aria-label="Toggle theme"
    >
      <span className="pi pi-circle-fill text-[0.6rem]" aria-hidden="true" />
      <span>Theme</span>
    </button>
  );
}
