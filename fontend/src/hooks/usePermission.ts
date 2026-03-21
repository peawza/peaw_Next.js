"use client";

import { useCallback, useMemo } from "react";
import { useSession } from "next-auth/react";
import {
  PermissionFunctionCode,
  getObjectPermissions,
  hasPermission as hasPermissionByMap,
  parsePermissionScreen,
} from "@/lib/permissions";

export function useHasPermission() {
  const { data: session } = useSession();

  const permissionMap = useMemo(
    () => parsePermissionScreen(session?.permissionScreen),
    [session?.permissionScreen],
  );

  return useCallback(
    (objectId: string, functionCode: number = PermissionFunctionCode.View) =>
      hasPermissionByMap(permissionMap, objectId, functionCode),
    [permissionMap],
  );
}

export function useObjectPermissions(objectId: string) {
  const { data: session } = useSession();

  return useMemo(
    () => getObjectPermissions(session?.permissionScreen, objectId),
    [objectId, session?.permissionScreen],
  );
}
