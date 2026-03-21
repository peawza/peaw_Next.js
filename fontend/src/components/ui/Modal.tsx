"use client";

import { Dialog } from "primereact/dialog";
import type { DialogProps } from "primereact/dialog";

export function Modal(props: DialogProps) {
  return <Dialog modal {...props} />;
}
