"use client";

import Link from "next/link";

export default function Forbidden() {
  return (
    <div className="flex min-h-screen items-center justify-center bg-slate-50 px-4 dark:bg-slate-950">
      <div className="w-full max-w-lg text-center">
        {/* Icon */}
        <div className="mx-auto mb-6 flex h-24 w-24 items-center justify-center rounded-full bg-red-100 dark:bg-red-900/30">
          <span className="pi pi-lock text-4xl text-red-500 dark:text-red-400" aria-hidden="true" />
        </div>

        {/* Error code */}
        <h1 className="bg-linear-to-r from-red-500 to-orange-500 bg-clip-text text-8xl font-black tracking-tight text-transparent">
          403
        </h1>

        {/* Subtitle */}
        <h2 className="mt-4 text-xl font-bold uppercase tracking-widest text-slate-700 dark:text-slate-200">
          Forbidden Error
        </h2>

        {/* Description */}
        <p className="mt-3 text-sm uppercase tracking-wide text-slate-500 dark:text-slate-400">
          You don&apos;t have permission to access this resource.
        </p>

        {/* Divider */}
        <div className="mx-auto my-8 h-px w-16 bg-slate-300 dark:bg-slate-700" />

        {/* Back to home button */}
        <Link
          href="/dashboard"
          className="inline-flex items-center gap-2 rounded-xl bg-linear-to-r from-indigo-500 to-purple-600 px-6 py-3 text-sm font-semibold uppercase tracking-wider text-white shadow-lg transition-all hover:from-indigo-600 hover:to-purple-700 hover:shadow-xl active:scale-95"
        >
          <span className="pi pi-home text-sm" aria-hidden="true" />
          Back to Home
        </Link>
      </div>
    </div>
  );
}
