export type JsonApiSuccessResult = {
  status: "success";
  payload: unknown;
};

export type JsonApiErrorResult = {
  status: "error";
  message: string;
  httpStatus: number;
  payload: unknown;
};

function isRecord(value: unknown): value is Record<string, unknown> {
  return typeof value === "object" && value !== null && !Array.isArray(value);
}

export function asString(value: unknown): string | null {
  if (typeof value === "string" && value.trim() !== "") {
    return value;
  }

  if (typeof value === "number" && Number.isFinite(value)) {
    return String(value);
  }

  return null;
}

export function parseJsonOrNull(input: string): unknown {
  if (!input || input.trim() === "") {
    return null;
  }

  try {
    return JSON.parse(input) as unknown;
  } catch {
    return null;
  }
}

export function readBooleanByKeys(input: unknown, keys: string[], depth = 0): boolean | null {
  if (depth > 6 || input == null) {
    return null;
  }

  if (typeof input === "boolean") {
    return input;
  }

  if (typeof input !== "object") {
    return null;
  }

  if (Array.isArray(input)) {
    for (const item of input) {
      const result = readBooleanByKeys(item, keys, depth + 1);
      if (result != null) {
        return result;
      }
    }
    return null;
  }

  const record = input as Record<string, unknown>;

  for (const key of keys) {
    const value = record[key];
    if (typeof value === "boolean") {
      return value;
    }
    if (typeof value === "string") {
      const normalized = value.trim().toLowerCase();
      if (normalized === "true") {
        return true;
      }
      if (normalized === "false") {
        return false;
      }
    }
  }

  for (const value of Object.values(record)) {
    const result = readBooleanByKeys(value, keys, depth + 1);
    if (result != null) {
      return result;
    }
  }

  return null;
}

export function readStringByKeys(input: unknown, keys: string[], depth = 0): string | null {
  if (depth > 6 || input == null) {
    return null;
  }

  const direct = asString(input);
  if (direct && depth > 0) {
    return direct;
  }

  if (typeof input !== "object") {
    return null;
  }

  if (Array.isArray(input)) {
    for (const item of input) {
      const result = readStringByKeys(item, keys, depth + 1);
      if (result) {
        return result;
      }
    }
    return null;
  }

  const record = input as Record<string, unknown>;

  for (const key of keys) {
    const value = asString(record[key]);
    if (value) {
      return value;
    }
  }

  for (const value of Object.values(record)) {
    const result = readStringByKeys(value, keys, depth + 1);
    if (result) {
      return result;
    }
  }

  return null;
}

export function readErrorMessage(input: unknown): string | null {
  return readStringByKeys(input, [
    "message",
    "Message",
    "error",
    "Error",
    "title",
    "Title",
    "detail",
    "Detail",
  ]);
}

export function isBackendExceptionPayload(input: unknown): boolean {
  if (!isRecord(input)) {
    return false;
  }

  const className = asString(input.ClassName ?? input.className);
  const stackTrace = asString(input.StackTraceString ?? input.stackTraceString);
  const paramName = asString(input.ParamName ?? input.paramName);
  const message = asString(input.Message ?? input.message);
  const hResult = input.HResult ?? input.hResult;

  if (!message) {
    return false;
  }

  return Boolean(className || stackTrace || paramName || hResult);
}

export function hasDirectLoginPayload(input: unknown): boolean {
  return readStringByKeys(input, ["Token", "token", "AccessToken"]) !== null;
}

export async function callJsonApi(
  endpoint: string,
  payload: Record<string, unknown>,
): Promise<JsonApiSuccessResult | JsonApiErrorResult> {
  const response = await fetch(endpoint, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(payload),
    cache: "no-store",
  });

  const responseText = await response.text();
  const responseBody = parseJsonOrNull(responseText) ?? responseText;

  if (!response.ok) {
    return {
      status: "error",
      message: "Request failed",
      httpStatus: response.status,
      payload: responseBody,
    };
  }

  return {
    status: "success",
    payload: responseBody,
  };
}
