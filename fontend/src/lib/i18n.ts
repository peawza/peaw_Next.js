"use client";

import i18n from "i18next";
import { initReactI18next } from "react-i18next";
import { loadLocalizedResourcesBundle } from "@/services/resourceService.client";
import type {
  LanguageCode,
  LocalizedResourceBundle,
  MessageResourceItem,
  ScreenResourceScreen,
  SystemResourceItem,
} from "@/types";

type I18nLanguageResources = {
  en: Record<string, string>;
  th: Record<string, string>;
};

let isI18nInitialized = false;
let initializingPromise: Promise<void> | null = null;

function isI18nDebugEnabled(): boolean {
  if (process.env.NEXT_PUBLIC_I18N_DEBUG === "true") {
    return true;
  }

  if (typeof window === "undefined") {
    return false;
  }

  try {
    const fromStorage = window.localStorage.getItem("i18n-debug");
    if (typeof fromStorage === "string" && fromStorage.toLowerCase() === "true") {
      return true;
    }
  } catch {
    // Ignore localStorage access errors.
  }

  const debugWindow = window as Window & { __I18N_DEBUG__?: boolean };
  return debugWindow.__I18N_DEBUG__ === true;
}

function debugLog(message: string, details?: unknown): void {
  if (!isI18nDebugEnabled()) {
    return;
  }

  if (details === undefined) {
    console.log(`[i18n] ${message}`);
    return;
  }

  console.log(`[i18n] ${message}`, details);
}

function normalizeLanguageCode(value: string | null | undefined): LanguageCode {
  const normalized = String(value).toLowerCase();
  return normalized === "th" || normalized === "lc" ? "th" : "en";
}

export function transformToI18n(data: SystemResourceItem[]): I18nLanguageResources {
  const en: Record<string, string> = {};
  const th: Record<string, string> = {};

  data.forEach(({ ScreenCode, ObjectID, ResourcesEN, ResourcesTH }) => {
    const screenCode = String(ScreenCode ?? "").trim();
    const objectId = String(ObjectID ?? "").trim();
    if (!screenCode || !objectId) {
      return;
    }

    const key = `${screenCode}.${objectId}`;
    en[key] = ResourcesEN ?? "";
    th[key] = ResourcesTH ?? "";
  });

  return { en, th };
}

function transformMessagesToI18n(data: MessageResourceItem[]): I18nLanguageResources {
  const en: Record<string, string> = {};
  const th: Record<string, string> = {};

  data.forEach(({ MessageCode, MessageType, MessageNameEN, MessageNameTH }) => {
    const code = String(MessageCode ?? "").trim();
    if (!code) {
      return;
    }

    const messageType = String(MessageType ?? "").trim();
    const messageKeys = [`Message.${code}`, code];
    if (messageType) {
      messageKeys.push(`${code}.${messageType}`);
    }

    for (const key of messageKeys) {
      en[key] = MessageNameEN ?? "";
      th[key] = MessageNameTH ?? "";
    }
  });

  return { en, th };
}

function transformScreensToI18n(data: ScreenResourceScreen[]): I18nLanguageResources {
  const en: Record<string, string> = {};
  const th: Record<string, string> = {};

  data.forEach(({ ScreenId, Name_EN, Name_TH, PageTitleName_EN, PageTitleName_TH }) => {
    const screenId = String(ScreenId ?? "").trim();
    if (!screenId) {
      return;
    }

    en[`Screen.${screenId}.Name`] = Name_EN ?? "";
    th[`Screen.${screenId}.Name`] = Name_TH ?? "";
    en[`Screen.${screenId}.PageTitle`] = PageTitleName_EN ?? Name_EN ?? "";
    th[`Screen.${screenId}.PageTitle`] = PageTitleName_TH ?? Name_TH ?? "";
  });

  return { en, th };
}

function mergeLanguageResources(
  ...resourcesList: I18nLanguageResources[]
): I18nLanguageResources {
  return resourcesList.reduce<I18nLanguageResources>(
    (accumulator, current) => ({
      en: {
        ...accumulator.en,
        ...current.en,
      },
      th: {
        ...accumulator.th,
        ...current.th,
      },
    }),
    { en: {}, th: {} },
  );
}

function applyBundleToI18n(bundle: LocalizedResourceBundle): void {
  const resources = transformToI18n(bundle.resourcesRaw);
  const messages = transformMessagesToI18n(bundle.messagesRaw);
  const screens = transformScreensToI18n(bundle.screenResources.Screen);
  const merged = mergeLanguageResources(resources, messages, screens);

  debugLog("apply bundle", {
    resources: Object.keys(merged.en).length,
    messages: bundle.messagesRaw.length,
    screens: bundle.screenResources.Screen.length,
  });

  i18n.addResourceBundle("en", "translation", merged.en, true, true);
  i18n.addResourceBundle("th", "translation", merged.th, true, true);
}

async function ensureInitialized(defaultLang: LanguageCode): Promise<void> {
  if (isI18nInitialized) {
    return;
  }

  if (!initializingPromise) {
    initializingPromise = i18n
      .use(initReactI18next)
      .init({
        lng: defaultLang,
        fallbackLng: "en",
        keySeparator: false,
        resources: {
          en: { translation: {} },
          th: { translation: {} },
        },
        interpolation: { escapeValue: false },
        react: { useSuspense: false },
      })
      .then(() => {
        isI18nInitialized = true;
      })
      .finally(() => {
        initializingPromise = null;
      });
  }

  await initializingPromise;
}

export async function initI18n(
  defaultLang: LanguageCode = "en",
  customerId?: string | null,
): Promise<typeof i18n> {
  const normalizedLang = normalizeLanguageCode(defaultLang);
  await ensureInitialized(normalizedLang);

  const normalizedCustomerId = String(customerId ?? "").trim();
  debugLog("init start", { normalizedLang, normalizedCustomerId });
  const bundle = await loadLocalizedResourcesBundle(normalizedCustomerId);
  applyBundleToI18n(bundle);

  if (i18n.language !== normalizedLang) {
    await i18n.changeLanguage(normalizedLang);
    debugLog("language changed", { normalizedLang });
  }

  return i18n;
}

export { i18n };
