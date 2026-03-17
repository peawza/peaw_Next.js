"use client";

import { Button as PrimeButton } from "primereact/button";
import type { ButtonProps } from "primereact/button";
import { PermissionFunctionCode } from "@/lib/permissions";
import { useHasPermission } from "@/hooks/usePermission";

// ---------------------------------------------------------------------------
// Types
// ---------------------------------------------------------------------------

type PermissionBehavior = "hide" | "disable";

type CommandButtonProps = ButtonProps & {
  /** Screen / object ID for permission check. If omitted the button is always shown. */
  objectId?: string;
  /** Which permission function code to check (default: View). */
  functionCode?: number;
  /** What to do when permission is denied: hide the button or disable it. */
  permissionBehavior?: PermissionBehavior;
};

// ---------------------------------------------------------------------------
// Helpers
// ---------------------------------------------------------------------------

type PresetProps = Omit<CommandButtonProps, "severity" | "icon" | "label"> & {
  label?: string;
};

function presetButton(
  defaultLabel: string,
  defaultIcon: string,
  defaultSeverity: ButtonProps["severity"],
  defaultFunctionCode?: number,
) {
  const Preset = ({
    label,
    functionCode,
    ...rest
  }: PresetProps) => (
    <CommandButton
      label={label ?? defaultLabel}
      icon={defaultIcon}
      severity={defaultSeverity}
      functionCode={functionCode ?? defaultFunctionCode}
      {...rest}
    />
  );
  Preset.displayName = `${defaultLabel}Button`;
  return Preset;
}

// ---------------------------------------------------------------------------
// CommandButton
// ---------------------------------------------------------------------------

export function CommandButton({
  objectId,
  functionCode = PermissionFunctionCode.View,
  permissionBehavior = "hide",
  ...buttonProps
}: CommandButtonProps) {
  const hasPermission = useHasPermission();

  if (objectId) {
    const allowed = hasPermission(objectId, functionCode);

    if (!allowed && permissionBehavior === "hide") {
      return null;
    }

    if (!allowed && permissionBehavior === "disable") {
      return <PrimeButton {...buttonProps} disabled />;
    }
  }

  return <PrimeButton {...buttonProps} />;
}

// ---------------------------------------------------------------------------
// Preset buttons  (mapped from legacy .NET Kendo helpers)
// ---------------------------------------------------------------------------

/** Apply – contrast (dark) */
export const ApplyButton = presetButton("Apply", "pi pi-check", "contrast");

/** Search – primary */
export const SearchButton = presetButton("Search", "pi pi-search", undefined);

/** Save – success (requires Edit permission when objectId is given) */
export const SaveButton = presetButton("Save", "pi pi-save", "success", PermissionFunctionCode.Edit);

/** Close – warning */
export const CloseButton = presetButton("Close", "pi pi-times", "warning");

/** Exit Form – warning */
export const ExitFormButton = presetButton("Exit Form", "pi pi-arrow-left", "warning");

/** Delete – danger (requires Delete permission when objectId is given) */
export const DeleteButton = presetButton("Delete", "pi pi-trash", "danger", PermissionFunctionCode.Delete);

/** Refresh – success */
export const RefreshButton = presetButton("Refresh", "pi pi-refresh", "success");

/** Clear – warning */
export const ClearButton = presetButton("Clear", "pi pi-refresh", "warning");

/** Reset – danger */
export const ResetButton = presetButton("Reset", "pi pi-undo", "danger");

/** Import – contrast (dark) */
export const ImportButton = presetButton("Import", "pi pi-upload", "contrast");

/** Export – success (requires Export permission when objectId is given) */
export const ExportButton = presetButton("Export", "pi pi-download", "success", PermissionFunctionCode.Export);

/** Add – success (requires New permission when objectId is given) */
export const AddButton = presetButton("Add", "pi pi-plus-circle", "success", PermissionFunctionCode.New);

/** New – success (requires New permission when objectId is given) */
export const NewButton = presetButton("New", "pi pi-plus-circle", "success", PermissionFunctionCode.New);

/** New Document – danger (requires New permission when objectId is given) */
export const NewDocumentButton = presetButton("New Document", "pi pi-plus-circle", "danger", PermissionFunctionCode.New);

/** Cancel – danger */
export const CancelButton = presetButton("Cancel", "pi pi-times", "danger");

/** Download – contrast (dark) */
export const DownloadButton = presetButton("Download", "pi pi-download", "contrast");

/** Submit – primary */
export const SubmitButton = presetButton("Submit", "pi pi-send", undefined);

/** Approve – success */
export const ApproveButton = presetButton("Approve", "pi pi-check-circle", "success");

/** Re-Approve – warning */
export const ReApproveButton = presetButton("Re-Approve", "pi pi-replay", "warning");

/** Reject – danger */
export const RejectButton = presetButton("Reject", "pi pi-times-circle", "danger");

/** Print – danger (requires Print permission when objectId is given) */
export const PrintButton = presetButton("Print", "pi pi-print", "danger", PermissionFunctionCode.Print);

/** Upload – warning */
export const UploadButton = presetButton("Upload", "pi pi-upload", "warning");

/** Scan – success */
export const ScanButton = presetButton("Scan", "pi pi-qrcode", "success");

/** Load Data – primary */
export const LoadDataButton = presetButton("Load Data", "pi pi-search", undefined);

/** Delete Tab – danger (requires Delete permission when objectId is given) */
export const DeleteTabButton = presetButton("Delete Tab", "pi pi-trash", "danger", PermissionFunctionCode.Delete);

/** Workflow History – primary */
export const WorkFlowHisButton = presetButton("Workflow History", "pi pi-history", undefined);
