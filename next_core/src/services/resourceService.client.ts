"use client";

import type {
  LanguageCode,
  LocalizedResourceBundle,
  LocalizedResourcesDictionary,
  MessageResourcesDictionary,
  ScreenResourceScreen,
  ScreenResourcesPayload,
  SystemResourceItem,
} from "@/types";

type LocalizedResourceBundleCache = {
  expiresAt: number;
  data: LocalizedResourceBundle;
};

const RESOURCE_CACHE_PREFIX = "localized-resources:";
const GLOBAL_RESOURCE_SCOPE = "__global__";
const DEFAULT_RESOURCE_CACHE_TTL_MINUTES = 60;
const DEFAULT_LOCALIZED_RESOURCES_API_PATH = "/api/auth/resources/localized";
const LEGACY_LOCALIZED_RESOURCES_API_PATH = "/api/resources/localized";
const pendingRequests = new Map<string, Promise<LocalizedResourceBundle>>();

const EMPTY_SCREEN_RESOURCES: ScreenResourcesPayload = {
  Module: [],
  SubModule: [],
  Screen: [],
};

const EMPTY_BUNDLE: LocalizedResourceBundle = {
  resources: {},
  messages: {},
  screenResources: EMPTY_SCREEN_RESOURCES,
  resourcesRaw: [],
  messagesRaw: [],
};

function hasBundleContent(bundle: LocalizedResourceBundle): boolean {
  return (
    bundle.resourcesRaw.length > 0 ||
    bundle.messagesRaw.length > 0 ||
    bundle.screenResources.Screen.length > 0
  );
}

function asNonEmptyString(value: unknown): string | null {
  return typeof value === "string" && value.trim() !== "" ? value.trim() : null;
}

function normalizeCustomerId(value: unknown): string {
  const resolvedValue = asNonEmptyString(value);
  if (!resolvedValue) {
    return "";
  }

  const lowered = resolvedValue.toLowerCase();
  if (lowered === "0" || lowered === "null" || lowered === "undefined") {
    return "";
  }

  return resolvedValue;
}

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

function resolveCacheScope(customerId?: string | null): string {
  const normalizedCustomerId = normalizeCustomerId(customerId);
  if (!normalizedCustomerId) {
    return GLOBAL_RESOURCE_SCOPE;
  }
  return normalizedCustomerId.toLowerCase();
}

function getCacheTtlMs(): number {
  const envValue = asNonEmptyString(process.env.NEXT_PUBLIC_LOCALIZED_RESOURCES_TTL_MINUTES);
  if (!envValue) {
    return DEFAULT_RESOURCE_CACHE_TTL_MINUTES * 60 * 1000;
  }

  const parsedMinutes = Number(envValue);
  if (!Number.isFinite(parsedMinutes) || parsedMinutes <= 0) {
    return DEFAULT_RESOURCE_CACHE_TTL_MINUTES * 60 * 1000;
  }

  return parsedMinutes * 60 * 1000;
}

function getCacheKey(scope: string): string {
  return `${RESOURCE_CACHE_PREFIX}${scope.toLowerCase()}`;
}

function normalizeBundle(value: unknown): LocalizedResourceBundle | null {
  if (!value || typeof value !== "object") {
    return null;
  }

  const record = value as Record<string, unknown>;

  // Backward compatibility: old cache stored only dictionary.
  if (!("resources" in record) && !("messages" in record) && !("screenResources" in record)) {
    return {
      ...EMPTY_BUNDLE,
      resources: record as LocalizedResourcesDictionary,
    };
  }

  const resources =
    record.resources && typeof record.resources === "object"
      ? (record.resources as LocalizedResourcesDictionary)
      : {};

  const messages =
    record.messages && typeof record.messages === "object"
      ? (record.messages as MessageResourcesDictionary)
      : {};

  const screenResources =
    record.screenResources && typeof record.screenResources === "object"
      ? (record.screenResources as ScreenResourcesPayload)
      : EMPTY_SCREEN_RESOURCES;

  const resourcesRaw = Array.isArray(record.resourcesRaw)
    ? (record.resourcesRaw as SystemResourceItem[])
    : [];

  const messagesRaw = Array.isArray(record.messagesRaw)
    ? (record.messagesRaw as LocalizedResourceBundle["messagesRaw"])
    : [];

  return {
    resources,
    messages,
    screenResources,
    resourcesRaw,
    messagesRaw,
  };
}

function readCache(scope: string): LocalizedResourceBundle | null {
  if (typeof window === "undefined") {
    return null;
  }

  try {
    const cacheKey = getCacheKey(scope);
    const rawValue = window.localStorage.getItem(cacheKey);
    if (!rawValue) {
      debugLog("cache miss", { scope });
      return null;
    }

    const parsed = JSON.parse(rawValue) as LocalizedResourceBundleCache;
    if (!parsed || typeof parsed !== "object") {
      return null;
    }

    if (typeof parsed.expiresAt !== "number" || !parsed.data || typeof parsed.data !== "object") {
      return null;
    }

    if (Date.now() > parsed.expiresAt) {
      window.localStorage.removeItem(cacheKey);
      debugLog("cache expired", { scope });
      return null;
    }

    const normalizedBundle = normalizeBundle(parsed.data);
    if (!normalizedBundle) {
      window.localStorage.removeItem(cacheKey);
      debugLog("cache invalid", { scope });
      return null;
    }

    if (!hasBundleContent(normalizedBundle)) {
      window.localStorage.removeItem(cacheKey);
      debugLog("cache empty payload, evicted", { scope });
      return null;
    }

    debugLog("cache hit", {
      scope,
      resources: normalizedBundle.resourcesRaw.length,
      messages: normalizedBundle.messagesRaw.length,
      screens: normalizedBundle.screenResources.Screen.length,
    });

    return normalizedBundle;
  } catch {
    debugLog("cache parse failed", { scope });
    return null;
  }
}

function writeCache(scope: string, data: LocalizedResourceBundle): void {
  if (typeof window === "undefined") {
    return;
  }

  if (!hasBundleContent(data)) {
    debugLog("cache skip empty payload", { scope });
    return;
  }

  const payload: LocalizedResourceBundleCache = {
    expiresAt: Date.now() + getCacheTtlMs(),
    data,
  };

  try {
    window.localStorage.setItem(getCacheKey(scope), JSON.stringify(payload));
    debugLog("cache write", {
      scope,
      resources: data.resourcesRaw.length,
      messages: data.messagesRaw.length,
      screens: data.screenResources.Screen.length,
    });
  } catch {
    // Ignore quota errors.
    debugLog("cache write failed", { scope });
  }
}

async function fetchLocalizedResourcesBundle(
  customerId: string,
): Promise<LocalizedResourceBundle | null> {
  const normalizedCustomerId = normalizeCustomerId(customerId);
  const localizedResourcesPath =
    asNonEmptyString(process.env.NEXT_PUBLIC_LOCALIZED_RESOURCES_API_PATH) ??
    DEFAULT_LOCALIZED_RESOURCES_API_PATH;

  const endpoints = Array.from(
    new Set([localizedResourcesPath, DEFAULT_LOCALIZED_RESOURCES_API_PATH, LEGACY_LOCALIZED_RESOURCES_API_PATH]),
  );

  for (const endpoint of endpoints) {
    const queryParam =
      normalizedCustomerId !== ""
        ? `${endpoint.includes("?") ? "&" : "?"}customerId=${encodeURIComponent(normalizedCustomerId)}`
        : "";
    const requestUrl = `${endpoint}${queryParam}`;

    try {
      debugLog("fetch start", { requestUrl });

      const response = await fetch(requestUrl, {
        method: "GET",
        cache: "no-store",
      });

      if (!response.ok) {
        debugLog("fetch failed", { requestUrl, status: response.status });
        continue;
      }

      const body = (await response.json()) as {
        data?: LocalizedResourcesDictionary;
        messages?: MessageResourcesDictionary;
        screenResources?: ScreenResourcesPayload;
        resourcesRaw?: LocalizedResourceBundle["resourcesRaw"];
        messagesRaw?: LocalizedResourceBundle["messagesRaw"];
      };

      const bundle: LocalizedResourceBundle = {
        resources: body.data && typeof body.data === "object" ? body.data : {},
        messages: body.messages && typeof body.messages === "object" ? body.messages : {},
        screenResources:
          body.screenResources && typeof body.screenResources === "object"
            ? body.screenResources
            : EMPTY_SCREEN_RESOURCES,
        resourcesRaw: Array.isArray(body.resourcesRaw) ? body.resourcesRaw : [],
        messagesRaw: Array.isArray(body.messagesRaw) ? body.messagesRaw : [],
      };

      debugLog("fetch success", {
        requestUrl,
        resources: bundle.resourcesRaw.length,
        messages: bundle.messagesRaw.length,
        screens: bundle.screenResources.Screen.length,
      });

      return bundle;
    } catch {
      debugLog("fetch exception", { requestUrl });
    }
  }

  return null;
}

export async function loadLocalizedResourcesBundle(
  customerId?: string | null,
  options?: { forceReload?: boolean },
): Promise<LocalizedResourceBundle> {
  const normalizedCustomerId = normalizeCustomerId(customerId);
  const cacheScope = resolveCacheScope(normalizedCustomerId);

  if (!options?.forceReload) {
    const fromCache = readCache(cacheScope);
    if (fromCache) {
      return fromCache;
    }
  }

  const requestKey = `${cacheScope}:${options?.forceReload ? "force" : "normal"}`;
  const pendingRequest = pendingRequests.get(requestKey);
  if (pendingRequest) {
    return pendingRequest;
  }

  const requestPromise = (async () => {
    const bundle = await fetchLocalizedResourcesBundle(normalizedCustomerId);
    if (bundle) {
      writeCache(cacheScope, bundle);
      return bundle;
    }

    debugLog("fetch returned empty bundle", { cacheScope });
    return EMPTY_BUNDLE;
  })().finally(() => {
    pendingRequests.delete(requestKey);
  });

  pendingRequests.set(requestKey, requestPromise);
  return requestPromise;
}

export async function loadLocalizedResources(
  customerId: string,
  options?: { forceReload?: boolean },
): Promise<LocalizedResourcesDictionary> {
  const bundle = await loadLocalizedResourcesBundle(customerId, options);
  return bundle.resources;
}

export async function loadMessageResources(
  customerId: string,
  options?: { forceReload?: boolean },
): Promise<MessageResourcesDictionary> {
  const bundle = await loadLocalizedResourcesBundle(customerId, options);
  return bundle.messages;
}

export async function loadScreenResources(
  customerId: string,
  options?: { forceReload?: boolean },
): Promise<ScreenResourcesPayload> {
  const bundle = await loadLocalizedResourcesBundle(customerId, options);
  return bundle.screenResources;
}

export function clearLocalizedResourcesCache(customerId?: string): void {
  if (typeof window === "undefined") {
    return;
  }

  if (customerId && customerId.trim() !== "") {
    const scope = resolveCacheScope(customerId);
    window.localStorage.removeItem(getCacheKey(scope));
    debugLog("cache cleared by scope", { scope });
    return;
  }

  const keysToDelete: string[] = [];
  for (let index = 0; index < window.localStorage.length; index += 1) {
    const key = window.localStorage.key(index);
    if (key?.startsWith(RESOURCE_CACHE_PREFIX)) {
      keysToDelete.push(key);
    }
  }

  for (const key of keysToDelete) {
    window.localStorage.removeItem(key);
  }

  debugLog("cache cleared all");
}

function normalizeLanguageCode(languageCode: string | null | undefined): LanguageCode {
  return String(languageCode).toLowerCase() === "th" ? "th" : "en";
}

export function getResourceText(
  resources: LocalizedResourcesDictionary,
  key: string,
  languageCode?: string | null,
  fallback?: string,
): string {
  const normalizedKey = key.trim().toLowerCase();
  if (!normalizedKey) {
    return fallback ?? key;
  }

  const item = resources[normalizedKey];
  if (!item) {
    return fallback ?? key;
  }

  const language = normalizeLanguageCode(languageCode);
  return language === "th" ? item.ResourcesTH || fallback || key : item.ResourcesEN || fallback || key;
}

export function getMessageText(
  messages: MessageResourcesDictionary,
  messageCode: string,
  languageCode?: string | null,
  fallback?: string,
): string {
  const normalizedCode = messageCode.trim().toLowerCase();
  if (!normalizedCode) {
    return fallback ?? messageCode;
  }

  const message = messages[normalizedCode];
  if (!message) {
    return fallback ?? messageCode;
  }

  const language = normalizeLanguageCode(languageCode);
  return language === "th"
    ? message.MessageNameTH || fallback || messageCode
    : message.MessageNameEN || fallback || messageCode;
}

export function getScreenDisplayName(
  screens: ScreenResourceScreen[],
  screenId: string,
  languageCode?: string | null,
  fallback?: string,
): string {
  const normalizedScreenId = screenId.trim().toLowerCase();
  if (!normalizedScreenId) {
    return fallback ?? screenId;
  }

  const screen = screens.find(
    (item) => String(item.ScreenId).trim().toLowerCase() === normalizedScreenId,
  );

  if (!screen) {
    return fallback ?? screenId;
  }

  const language = normalizeLanguageCode(languageCode);
  return language === "th" ? screen.Name_TH || fallback || screenId : screen.Name_EN || fallback || screenId;
}
