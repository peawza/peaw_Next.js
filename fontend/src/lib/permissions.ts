export const PermissionFunctionCode = {
  View: 1,
  New: 2,
  Edit: 4,
  Delete: 8,
  Export: 16,
  Print: 32,
} as const;

export const PermissionNames = {
  View: { FunctionCode: PermissionFunctionCode.View },
  New: { FunctionCode: PermissionFunctionCode.New },
  Edit: { FunctionCode: PermissionFunctionCode.Edit },
  Delete: { FunctionCode: PermissionFunctionCode.Delete },
  Export: { FunctionCode: PermissionFunctionCode.Export },
  Print: { FunctionCode: PermissionFunctionCode.Print },
} as const;

export type PermissionMap = Record<string, number[]>;

export type ObjectPermissionSet = {
  AllowView: boolean;
  AllowNew: boolean;
  AllowEdit: boolean;
  AllowDelete: boolean;
  AllowExport: boolean;
  AllowPrint: boolean;
};

function normalizeBase64(value: string): string {
  const normalizedValue = value.replace(/-/g, "+").replace(/_/g, "/");
  const paddingNeeded = (4 - (normalizedValue.length % 4)) % 4;
  return normalizedValue + "=".repeat(paddingNeeded);
}

function decodeBase64ToUtf8(value: string): string | null {
  const normalizedValue = normalizeBase64(value);

  try {
    if (typeof window === "undefined") {
      return Buffer.from(normalizedValue, "base64").toString("utf-8");
    }

    const binary = window.atob(normalizedValue);
    const bytes = Uint8Array.from(binary, (char) => char.charCodeAt(0));
    return new TextDecoder().decode(bytes);
  } catch {
    return null;
  }
}

function toFunctionCodes(value: unknown): number[] {
  if (Array.isArray(value)) {
    return value
      .map((item) => Number(item))
      .filter((item) => Number.isFinite(item))
      .map((item) => Math.trunc(item));
  }

  if (typeof value === "number" && Number.isFinite(value)) {
    return [Math.trunc(value)];
  }

  if (typeof value === "string" && value.trim() !== "") {
    const parsedNumber = Number(value);
    if (Number.isFinite(parsedNumber)) {
      return [Math.trunc(parsedNumber)];
    }
  }

  return [];
}

export function parsePermissionScreen(permissionScreen?: string | null): PermissionMap {
  if (!permissionScreen || permissionScreen.trim() === "") {
    return {};
  }

  const rawValue = permissionScreen.trim();
  const jsonText = rawValue.startsWith("{") ? rawValue : decodeBase64ToUtf8(rawValue);

  if (!jsonText) {
    return {};
  }

  try {
    const parsed = JSON.parse(jsonText) as unknown;
    if (!parsed || typeof parsed !== "object" || Array.isArray(parsed)) {
      return {};
    }

    const permissionMap: PermissionMap = {};

    for (const [key, value] of Object.entries(parsed as Record<string, unknown>)) {
      const functionCodes = toFunctionCodes(value);
      if (functionCodes.length > 0) {
        permissionMap[key] = functionCodes;
      }
    }

    return permissionMap;
  } catch {
    return {};
  }
}

export function hasPermission(
  permissionSource: string | PermissionMap | null | undefined,
  objectId: string,
  functionCode: number = PermissionFunctionCode.View,
): boolean {
  if (!objectId || objectId.trim() === "") {
    return true;
  }

  const permissionMap =
    typeof permissionSource === "string" || permissionSource == null
      ? parsePermissionScreen(permissionSource)
      : permissionSource;

  const objectIds = objectId
    .split(",")
    .map((value) => value.trim())
    .filter((value) => value !== "");

  if (objectIds.length === 0) {
    return true;
  }

  let result = false;

  for (const value of objectIds) {
    const arrayFunctionCode = permissionMap[value];
    if (!arrayFunctionCode || arrayFunctionCode.length === 0) {
      continue;
    }

    for (const code of arrayFunctionCode) {
      if (!result) {
        result ||= (code & functionCode) > 0;
      }
    }
  }

  return result;
}

export function getObjectPermissions(
  permissionSource: string | PermissionMap | null | undefined,
  objectId: string,
): ObjectPermissionSet {
  return {
    AllowView: hasPermission(permissionSource, objectId, PermissionFunctionCode.View),
    AllowNew: hasPermission(permissionSource, objectId, PermissionFunctionCode.New),
    AllowEdit: hasPermission(permissionSource, objectId, PermissionFunctionCode.Edit),
    AllowDelete: hasPermission(permissionSource, objectId, PermissionFunctionCode.Delete),
    AllowExport: hasPermission(permissionSource, objectId, PermissionFunctionCode.Export),
    AllowPrint: hasPermission(permissionSource, objectId, PermissionFunctionCode.Print),
  };
}
