"use client";

import { useState } from "react";
import { signOut, useSession } from "next-auth/react";
import { useRouter } from "next/navigation";

type LanguageCode = "en" | "th";

function normalizeLanguageCode(value: unknown): LanguageCode {
  if (typeof value !== "string") {
    return "en";
  }

  const normalized = value.toLowerCase();
  if (normalized === "th" || normalized === "lc") {
    return "th";
  }

  return "en";
}

export function LanguageSwitcher() {
  const router = useRouter();
  const { data: session, status, update } = useSession();
  const [pendingCode, setPendingCode] = useState<LanguageCode | null>(null);

  const currentLanguageCode = normalizeLanguageCode(session?.languageCode);

  const changeLanguage = async (languageCode: LanguageCode) => {
    if (status !== "authenticated" || pendingCode || currentLanguageCode === languageCode) {
      return;
    }

    setPendingCode(languageCode);

    try {
      const updatedSession = await update({
        languageCode,
      });

      if (updatedSession?.authError === "RefreshAccessTokenError") {
        await signOut({ callbackUrl: "/login" });
        return;
      }

      router.refresh();
    } finally {
      setPendingCode(null);
    }
  };

  return (
    <div className="inline-flex items-center overflow-hidden rounded-md border border-slate-200">
      <button
        type="button"
        onClick={() => changeLanguage("en")}
        disabled={pendingCode !== null}
        className={`px-2 py-1 text-xs font-semibold transition ${
          currentLanguageCode === "en"
            ? "bg-slate-900 text-white"
            : "bg-white text-slate-700 hover:bg-slate-100"
        } ${pendingCode !== null ? "opacity-70" : ""}`}
        title="Switch to English"
      >
        <span className="mr-1" aria-hidden="true">
          🇬🇧
        </span>
        EN
      </button>
      <button
        type="button"
        onClick={() => changeLanguage("th")}
        disabled={pendingCode !== null}
        className={`px-2 py-1 text-xs font-semibold transition ${
          currentLanguageCode === "th"
            ? "bg-slate-900 text-white"
            : "bg-white text-slate-700 hover:bg-slate-100"
        } ${pendingCode !== null ? "opacity-70" : ""}`}
        title="สลับเป็นภาษาไทย"
      >
        <span className="mr-1" aria-hidden="true">
          🇹🇭
        </span>
        TH
      </button>
    </div>
  );
}
