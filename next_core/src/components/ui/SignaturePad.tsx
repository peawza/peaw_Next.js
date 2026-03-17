"use client";

import { useRef, useCallback, useEffect, useState } from "react";
import SignatureCanvas from "react-signature-canvas";

type SignaturePadProps = {
  /** Callback when signature changes — receives base64 PNG data URL or null when cleared */
  onChange?: (dataUrl: string | null) => void;
  /** Canvas height in px */
  height?: number;
  /** Pen color */
  penColor?: string;
  /** Label displayed above the pad */
  label?: string;
  /** Clear button label */
  clearLabel?: string;
};

export function SignaturePad({
  onChange,
  height = 200,
  penColor = "#1e293b",
  label = "Signature",
  clearLabel = "Clear",
}: SignaturePadProps) {
  const sigRef = useRef<SignatureCanvas | null>(null);
  const containerRef = useRef<HTMLDivElement | null>(null);
  const [isEmpty, setIsEmpty] = useState(true);
  const [canvasWidth, setCanvasWidth] = useState(0);

  // Keep canvas pixel size in sync with container width
  useEffect(() => {
    const container = containerRef.current;
    if (!container) return;

    const observer = new ResizeObserver((entries) => {
      for (const entry of entries) {
        const w = Math.floor(entry.contentRect.width);
        if (w > 0) setCanvasWidth(w);
      }
    });

    observer.observe(container);
    // Initial measurement
    setCanvasWidth(Math.floor(container.clientWidth));

    return () => observer.disconnect();
  }, []);

  // Clear & redraw when canvas resizes so strokes stay in sync
  useEffect(() => {
    if (!canvasWidth || !sigRef.current) return;
    sigRef.current.clear();
    setIsEmpty(true);
    onChange?.(null);
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [canvasWidth]);

  const handleEnd = useCallback(() => {
    if (!sigRef.current) return;
    const empty = sigRef.current.isEmpty();
    setIsEmpty(empty);
    onChange?.(empty ? null : sigRef.current.getTrimmedCanvas().toDataURL("image/png"));
  }, [onChange]);

  const handleClear = useCallback(() => {
    sigRef.current?.clear();
    setIsEmpty(true);
    onChange?.(null);
  }, [onChange]);

  return (
    <div className="flex flex-col gap-2">
      {label && (
        <span className="text-sm font-medium text-slate-700 dark:text-slate-300">{label}</span>
      )}
      <div
        ref={containerRef}
        className="relative overflow-hidden rounded-xl border-2 border-dashed border-slate-300 bg-white dark:border-slate-600 dark:bg-slate-800"
      >
        {canvasWidth > 0 && (
          <SignatureCanvas
            ref={sigRef}
            penColor={penColor}
            canvasProps={{
              width: canvasWidth,
              height,
              className: "cursor-crosshair",
              style: { width: canvasWidth, height, display: "block" },
            }}
            onEnd={handleEnd}
          />
        )}
        {isEmpty && (
          <p className="pointer-events-none absolute inset-0 flex items-center justify-center text-sm text-slate-400 dark:text-slate-500">
            Sign here
          </p>
        )}
      </div>
      <button
        type="button"
        onClick={handleClear}
        className="self-end rounded-lg px-4 py-1.5 text-xs font-medium text-slate-500 transition hover:bg-slate-100 hover:text-slate-700 dark:text-slate-400 dark:hover:bg-slate-700 dark:hover:text-slate-200"
      >
        <span className="pi pi-eraser mr-1.5" aria-hidden="true" />
        {clearLabel}
      </button>
    </div>
  );
}
