"use client";

import { ProgressSpinner } from "primereact/progressspinner";

export function LoadingSpinner() {
  return (
    <div className="flex items-center justify-center p-4">
      <ProgressSpinner style={{ width: "40px", height: "40px" }} strokeWidth="4" />
    </div>
  );
}
