"use client";

import { useEffect } from "react";
import { useSession } from "next-auth/react";
import { initI18n } from "@/lib/i18n";

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

export function LocalizedResourcesBootstrap() {
  const { data: session, status } = useSession();

  useEffect(() => {
    if (status === "loading") {
      return;
    }

    const languageCode = normalizeLanguageCode(session?.languageCode);
    const customerId =
      session?.customerId !== undefined && session?.customerId !== null
        ? String(session.customerId)
        : "";

    void initI18n(languageCode, customerId || null);
  }, [session?.customerId, session?.languageCode, status]);

  return null;
}
