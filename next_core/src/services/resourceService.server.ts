import "server-only";
import { resolveBackendAuthToken } from "@/lib/auth/microserviceAuth.server";
import type {
  LocalizedResourceBundle,
  LocalizedResourcesDictionary,
  MessageResourceItem,
  MessageResourcesDictionary,
  ScreenResourcesPayload,
  SystemResourceItem,
} from "@/types";

type LoadResourcesOptions = {
  accessToken?: string;
  supportDeviceType?: string;
};

const I18N_DEBUG_ENABLED =
  process.env.NEXT_PUBLIC_I18N_DEBUG === "true" || process.env.I18N_DEBUG === "true";

const EMPTY_SCREEN_RESOURCES: ScreenResourcesPayload = {
  Module: [],
  SubModule: [],
  Screen: [],
};

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

function isRecord(value: unknown): value is Record<string, unknown> {
  return typeof value === "object" && value !== null && !Array.isArray(value);
}

function parseJsonOrNull(input: string): unknown {
  if (!input || input.trim() === "") {
    return null;
  }

  try {
    return JSON.parse(input) as unknown;
  } catch {
    return null;
  }
}

function debugLog(message: string, details?: unknown): void {
  if (!I18N_DEBUG_ENABLED) {
    return;
  }

  if (details === undefined) {
    console.log(`[i18n-server] ${message}`);
    return;
  }

  console.log(`[i18n-server] ${message}`, details);
}

function buildApiEndpoint(path: string | undefined, fallbackPath: string): string | null {
  const apiBaseUrl = process.env.AUTH_API_URL ?? process.env.NEXT_PUBLIC_API_URL;
  const apiPath = path ?? fallbackPath;

  if (!apiBaseUrl) {
    return null;
  }

  if (/^https?:\/\//i.test(apiPath)) {
    return apiPath;
  }

  const normalizedBaseUrl = apiBaseUrl.endsWith("/") ? apiBaseUrl.slice(0, -1) : apiBaseUrl;
  const normalizedPath = (apiPath.startsWith("/") ? apiPath : `/${apiPath}`).replace(/\/{2,}/g, "/");

  return `${normalizedBaseUrl}${normalizedPath}`;
}

function buildApiEndpoints(path: string | undefined, fallbackPath: string): string[] {
  const endpointSet = new Set<string>();
  const primaryEndpoint = buildApiEndpoint(path, fallbackPath);
  if (primaryEndpoint) {
    endpointSet.add(primaryEndpoint);
  }

  const hasCustomPath = typeof path === "string" && path.trim() !== "";
  if (hasCustomPath) {
    const fallbackEndpoint = buildApiEndpoint(undefined, fallbackPath);
    if (fallbackEndpoint) {
      endpointSet.add(fallbackEndpoint);
    }
  }

  return Array.from(endpointSet);
}

function unwrapPayload(payload: unknown, depth = 0): unknown {
  if (depth > 4) {
    return payload;
  }

  if (Array.isArray(payload)) {
    return payload;
  }

  if (!isRecord(payload)) {
    return payload;
  }

  const wrapperKeys = ["data", "result", "payload", "items", "value"] as const;
  for (const key of wrapperKeys) {
    const candidate = payload[key];
    if (candidate !== undefined) {
      return unwrapPayload(candidate, depth + 1);
    }
  }

  return payload;
}

async function callBackendJson(
  endpoint: string,
  method: "GET" | "POST",
  accessToken?: string,
  body?: unknown,
): Promise<unknown | null> {
  try {
    debugLog("request start", { method, endpoint });
    const backendAuthToken = await resolveBackendAuthToken(accessToken);
    const response = await fetch(endpoint, {
      method,
      headers: {
        "Content-Type": "application/json",
        ...(backendAuthToken ? { Authorization: `Bearer ${backendAuthToken}` } : {}),
      },
      ...(body !== undefined ? { body: JSON.stringify(body) } : {}),
      cache: "no-store",
    });

    if (!response.ok) {
      const responseText = await response.text();
      const preview =
        responseText.length > 300 ? `${responseText.slice(0, 300)}...` : responseText;
      debugLog("request failed", {
        method,
        endpoint,
        status: response.status,
        statusText: response.statusText,
        body: preview,
      });
      return null;
    }

    const responseText = await response.text();
    const parsed = parseJsonOrNull(responseText) ?? responseText;
    debugLog("request success", {
      method,
      endpoint,
      payloadType: Array.isArray(parsed) ? "array" : typeof parsed,
    });
    return parsed;
  } catch {
    debugLog("request exception", { method, endpoint });
    return null;
  }
}

function extractArray<TRecord extends Record<string, unknown>>(payload: unknown): TRecord[] {
  const normalizedPayload = unwrapPayload(payload);
  if (!Array.isArray(normalizedPayload)) {
    return [];
  }

  return normalizedPayload.filter(isRecord) as TRecord[];
}

function buildResourcesDictionary(resources: SystemResourceItem[]): LocalizedResourcesDictionary {
  const dictionary: LocalizedResourcesDictionary = {};

  for (const resource of resources) {
    const screenCode = asNonEmptyString(resource.ScreenCode);
    const objectId = asNonEmptyString(resource.ObjectID);

    if (!screenCode || !objectId) {
      continue;
    }

    const scopedKey = `${screenCode}.${objectId}`.toLowerCase();
    const plainKey = objectId.toLowerCase();

    dictionary[scopedKey] = resource;
    if (!dictionary[plainKey]) {
      dictionary[plainKey] = resource;
    }
  }

  return dictionary;
}

function buildMessagesDictionary(messages: MessageResourceItem[]): MessageResourcesDictionary {
  const dictionary: MessageResourcesDictionary = {};

  for (const message of messages) {
    const messageCode = asNonEmptyString(message.MessageCode);
    if (!messageCode) {
      continue;
    }

    dictionary[messageCode.toLowerCase()] = message;
  }

  return dictionary;
}

function normalizeScreenResources(payload: unknown): ScreenResourcesPayload {
  const normalizedPayload = unwrapPayload(payload);
  if (!isRecord(normalizedPayload)) {
    return EMPTY_SCREEN_RESOURCES;
  }

  const moduleItems = Array.isArray(normalizedPayload.Module)
    ? normalizedPayload.Module.filter(isRecord)
    : [];
  const subModuleItems = Array.isArray(normalizedPayload.SubModule)
    ? normalizedPayload.SubModule.filter(isRecord)
    : [];
  const screenItems = Array.isArray(normalizedPayload.Screen)
    ? normalizedPayload.Screen.filter(isRecord)
    : [];

  return {
    Module: moduleItems as ScreenResourcesPayload["Module"],
    SubModule: subModuleItems as ScreenResourcesPayload["SubModule"],
    Screen: screenItems as ScreenResourcesPayload["Screen"],
  };
}

export async function loadSystemResources(
  customerId: string,
  options?: LoadResourcesOptions,
): Promise<SystemResourceItem[]> {
  const endpoints = buildApiEndpoints(
    process.env.AUTH_SYSTEM_RESOURCES_PATH,
    "/system/getresources",
  );

  if (endpoints.length === 0) {
    return [];
  }

  for (const endpoint of endpoints) {
    const url = new URL(endpoint);
    const normalizedCustomerId = normalizeCustomerId(customerId);
    if (normalizedCustomerId) {
      // Keep compatibility with legacy API that expects customer in query "type".
      url.searchParams.set("type", normalizedCustomerId);
    }

    const payload = await callBackendJson(url.toString(), "GET", options?.accessToken);
    if (payload !== null) {
      return extractArray<SystemResourceItem>(payload);
    }
  }

  return [];
}

export async function loadMessageResources(
  options?: LoadResourcesOptions,
): Promise<MessageResourceItem[]> {
  const endpoints = buildApiEndpoints(
    process.env.AUTH_SYSTEM_MESSAGES_PATH,
    "/system/getmessages",
  );

  if (endpoints.length === 0) {
    return [];
  }

  for (const endpoint of endpoints) {
    const payload = await callBackendJson(endpoint, "GET", options?.accessToken);
    if (payload !== null) {
      return extractArray<MessageResourceItem>(payload);
    }
  }

  return [];
}

export async function loadScreenResources(
  options?: LoadResourcesOptions,
): Promise<ScreenResourcesPayload> {
  const endpoints = buildApiEndpoints(
    process.env.AUTH_SYSTEM_SITEMAPS_PATH,
    "/system/getsitemaps",
  );

  if (endpoints.length === 0) {
    return EMPTY_SCREEN_RESOURCES;
  }

  for (const endpoint of endpoints) {
    const payload = await callBackendJson(endpoint, "POST", options?.accessToken, {
      SupportDeviceType: options?.supportDeviceType ?? "web",
    });
    if (payload !== null) {
      return normalizeScreenResources(payload);
    }
  }

  return EMPTY_SCREEN_RESOURCES;
}

export async function loadLocalizedResourceBundle(
  customerId: string,
  options?: LoadResourcesOptions,
): Promise<LocalizedResourceBundle> {
  const [resourcesRaw, messagesRaw, screenResources] = await Promise.all([
    loadSystemResources(customerId, options),
    loadMessageResources(options),
    loadScreenResources(options),
  ]);

  return {
    resources: buildResourcesDictionary(resourcesRaw),
    messages: buildMessagesDictionary(messagesRaw),
    screenResources,
    resourcesRaw,
    messagesRaw,
  };
}

export async function loadResourcesForCustomer(
  customerId: string,
  options?: LoadResourcesOptions,
): Promise<LocalizedResourcesDictionary> {
  const bundle = await loadLocalizedResourceBundle(customerId, options);
  return bundle.resources;
}
