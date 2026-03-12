"use client";

import type { ReactNode } from "react";
import { PermissionFunctionCode } from "@/lib/permissions";
import { useHasPermission } from "@/hooks/usePermission";

type PermissionGateProps = {
  objectId: string;
  functionCode?: number;
  children: ReactNode;
  fallback?: ReactNode;
};

export function PermissionGate({
  objectId,
  functionCode = PermissionFunctionCode.View,
  children,
  fallback = null,
}: PermissionGateProps) {
  const hasPermission = useHasPermission();

  if (!hasPermission(objectId, functionCode)) {
    return <>{fallback}</>;
  }

  return <>{children}</>;
}
