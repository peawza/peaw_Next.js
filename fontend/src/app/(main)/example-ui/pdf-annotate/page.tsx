"use client";

import { useRef, useState, useCallback, useEffect, useLayoutEffect } from "react";
import { PDFDocument, StandardFonts, rgb } from "pdf-lib";
import { Button } from "@/components/ui/Button";

// Lazy-load pdfjs-dist to avoid SSR (DOMMatrix not available in Node.js)
let pdfjsPromise: Promise<typeof import("pdfjs-dist")> | null = null;
function getPdfjs() {
  if (!pdfjsPromise) {
    pdfjsPromise = import("pdfjs-dist").then((mod) => {
      mod.GlobalWorkerOptions.workerSrc = `https://cdn.jsdelivr.net/npm/pdfjs-dist@${mod.version}/build/pdf.worker.min.mjs`;
      return mod;
    });
  }
  return pdfjsPromise;
}

// ---------------------------------------------------------------------------
// Types
// ---------------------------------------------------------------------------

type Annotation = {
  id: string;
  type: "text" | "draw";
  /** Position relative to PDF page (0–1 ratio) */
  x: number;
  y: number;
  text?: string;
  fontSize?: number;
  color?: string;
  /** Drawing path points (ratio) */
  points?: { x: number; y: number }[];
};

type ToolMode = "text" | "draw" | "select";

// ---------------------------------------------------------------------------
// Helpers
// ---------------------------------------------------------------------------

function generateId() {
  return Math.random().toString(36).slice(2, 10);
}

// ---------------------------------------------------------------------------
// Component
// ---------------------------------------------------------------------------

export default function PdfAnnotatePage() {
  const canvasRef = useRef<HTMLCanvasElement>(null);
  const overlayRef = useRef<HTMLCanvasElement>(null);
  const fileInputRef = useRef<HTMLInputElement>(null);
  const containerRef = useRef<HTMLDivElement>(null);

  const [pdfBytes, setPdfBytes] = useState<Uint8Array | null>(null);
  const [pageCount, setPageCount] = useState(0);
  const [currentPage, setCurrentPage] = useState(1);
  const [pdfDims, setPdfDims] = useState({ width: 0, height: 0 });
  /** The viewport scale used to render PDF — needed to scale annotation sizes */
  const renderScaleRef = useRef(1);

  const [tool, setTool] = useState<ToolMode>("text");
  const [penColor, setPenColor] = useState("#1e293b");
  const [fontSize, setFontSize] = useState(14);
  const [annotations, setAnnotations] = useState<Annotation[]>([]);
  const [isDrawing, setIsDrawing] = useState(false);
  const drawingPoints = useRef<{ x: number; y: number }[]>([]);

  const [editingId, setEditingId] = useState<string | null>(null);
  const [editText, setEditText] = useState("");
  const [editPos, setEditPos] = useState({ left: 0, top: 0 });

  const [isExporting, setIsExporting] = useState(false);

  // -----------------------------------------------------------------------
  // Render PDF page
  // -----------------------------------------------------------------------

  const renderPage = useCallback(
    async (data: Uint8Array, page: number) => {
      const canvas = canvasRef.current;
      const container = containerRef.current;
      if (!canvas || !container) return;

      const pdfjsLib = await getPdfjs();
      // Copy the data so pdfjs-dist doesn't detach the original ArrayBuffer
      const pdf = await pdfjsLib.getDocument({ data: new Uint8Array(data) }).promise;
      setPageCount(pdf.numPages);

      const pdfPage = await pdf.getPage(page);

      // Calculate scale to fit container width
      const baseViewport = pdfPage.getViewport({ scale: 1 });
      const maxWidth = container.clientWidth - 4;
      const scale = maxWidth > 0 ? maxWidth / baseViewport.width : 1.5;
      renderScaleRef.current = scale;
      const viewport = pdfPage.getViewport({ scale });

      const w = Math.floor(viewport.width);
      const h = Math.floor(viewport.height);

      canvas.width = w;
      canvas.height = h;
      setPdfDims({ width: w, height: h });

      const ctx = canvas.getContext("2d")!;
      ctx.clearRect(0, 0, w, h);
      const renderTask = pdfPage.render({ canvasContext: ctx, viewport, canvas } as never);
      await renderTask.promise;
    },
    [],
  );

  // Re-render when page changes
  useEffect(() => {
    if (!pdfBytes) return;
    void renderPage(pdfBytes, currentPage);
  }, [pdfBytes, currentPage, renderPage]);

  // -----------------------------------------------------------------------
  // Draw overlay (annotations)
  // Draws all committed annotations. Also syncs overlay buffer size to pdfDims.
  // -----------------------------------------------------------------------

  const drawOverlay = useCallback(() => {
    const overlay = overlayRef.current;
    if (!overlay || pdfDims.width === 0) return;

    const w = pdfDims.width;
    const h = pdfDims.height;

    // Sync buffer size only when it actually changed (resizing clears the canvas)
    if (overlay.width !== w || overlay.height !== h) {
      overlay.width = w;
      overlay.height = h;
    } else {
      const ctx = overlay.getContext("2d");
      ctx?.clearRect(0, 0, w, h);
    }

    const ctx = overlay.getContext("2d");
    if (!ctx) return;

    const scale = renderScaleRef.current;

    for (const ann of annotations) {
      if (ann.type === "text" && ann.text) {
        const px = ann.x * w;
        const py = ann.y * h;
        const fs = (ann.fontSize ?? 14) * scale;
        ctx.font = `${fs}px sans-serif`;
        ctx.fillStyle = ann.color ?? "#1e293b";
        ctx.fillText(ann.text, px, py);
      }

      if (ann.type === "draw" && ann.points && ann.points.length > 1) {
        ctx.beginPath();
        ctx.strokeStyle = ann.color ?? "#1e293b";
        ctx.lineWidth = 2 * scale;
        ctx.lineCap = "round";
        ctx.lineJoin = "round";
        const first = ann.points[0];
        ctx.moveTo(first.x * w, first.y * h);
        for (let i = 1; i < ann.points.length; i++) {
          ctx.lineTo(ann.points[i].x * w, ann.points[i].y * h);
        }
        ctx.stroke();
      }
    }
  }, [annotations, pdfDims]);

  // Redraw whenever annotations or pdfDims change (before browser paint)
  useLayoutEffect(() => {
    drawOverlay();
  }, [drawOverlay]);

  // -----------------------------------------------------------------------
  // File upload
  // -----------------------------------------------------------------------

  const handleFileChange = useCallback(
    async (e: React.ChangeEvent<HTMLInputElement>) => {
      const file = e.target.files?.[0];
      if (!file) return;
      const buffer = await file.arrayBuffer();
      setPdfBytes(new Uint8Array(buffer));
      setCurrentPage(1);
      setAnnotations([]);
    },
    [],
  );

  // -----------------------------------------------------------------------
  // Generate sample PDF if no file loaded
  // -----------------------------------------------------------------------

  const handleGenerateSample = useCallback(async () => {
    const doc = await PDFDocument.create();
    const page = doc.addPage([595, 842]);
    const font = await doc.embedFont(StandardFonts.Helvetica);
    const fontBold = await doc.embedFont(StandardFonts.HelveticaBold);
    const { height } = page.getSize();

    page.drawRectangle({ x: 50, y: height - 60, width: 495, height: 3, color: rgb(0.31, 0.27, 0.9) });
    page.drawText("Sample Document for Annotation", { x: 50, y: height - 90, size: 22, font: fontBold, color: rgb(0.1, 0.1, 0.1) });
    page.drawText("This is a sample PDF document. Click anywhere on it to add text or draw freely.", { x: 50, y: height - 130, size: 12, font, color: rgb(0.3, 0.3, 0.3) });
    page.drawText("Use the toolbar above to switch between Text mode and Draw mode.", { x: 50, y: height - 155, size: 12, font, color: rgb(0.3, 0.3, 0.3) });
    page.drawText("When finished, click Export PDF to download the annotated version.", { x: 50, y: height - 180, size: 12, font, color: rgb(0.3, 0.3, 0.3) });

    // Grid lines for visual reference
    for (let i = 0; i < 10; i++) {
      const lineY = height - 250 - i * 50;
      page.drawLine({ start: { x: 50, y: lineY }, end: { x: 545, y: lineY }, thickness: 0.3, color: rgb(0.85, 0.85, 0.85) });
    }

    const bytes = await doc.save();
    setPdfBytes(new Uint8Array(bytes));
    setCurrentPage(1);
    setAnnotations([]);
  }, []);

  // -----------------------------------------------------------------------
  // Canvas click / mouse handlers
  // -----------------------------------------------------------------------

  const getCanvasPos = (e: React.MouseEvent<HTMLCanvasElement>) => {
    const overlay = overlayRef.current!;
    const rect = overlay.getBoundingClientRect();
    return {
      x: (e.clientX - rect.left) / rect.width,
      y: (e.clientY - rect.top) / rect.height,
      px: e.clientX - rect.left,
      py: e.clientY - rect.top,
    };
  };

  const handleCanvasClick = (e: React.MouseEvent<HTMLCanvasElement>) => {
    if (tool !== "text") return;
    const pos = getCanvasPos(e);
    const id = generateId();
    setEditingId(id);
    setEditText("");
    setEditPos({ left: pos.px, top: pos.py });

    // Add placeholder annotation
    setAnnotations((prev) => [
      ...prev,
      { id, type: "text", x: pos.x, y: pos.y, text: "", fontSize, color: penColor },
    ]);
  };

  const handleTextCommit = () => {
    if (!editingId) return;
    if (!editText.trim()) {
      // Remove empty annotation
      setAnnotations((prev) => prev.filter((a) => a.id !== editingId));
    } else {
      setAnnotations((prev) =>
        prev.map((a) => (a.id === editingId ? { ...a, text: editText } : a)),
      );
    }
    setEditingId(null);
    setEditText("");
  };

  const handleMouseDown = (e: React.MouseEvent<HTMLCanvasElement>) => {
    if (tool !== "draw") return;
    setIsDrawing(true);
    const pos = getCanvasPos(e);
    drawingPoints.current = [{ x: pos.x, y: pos.y }];
  };

  const handleMouseMove = (e: React.MouseEvent<HTMLCanvasElement>) => {
    if (!isDrawing || tool !== "draw") return;
    const pos = getCanvasPos(e);
    drawingPoints.current.push({ x: pos.x, y: pos.y });

    // Live preview
    const overlay = overlayRef.current;
    if (!overlay) return;
    const ctx = overlay.getContext("2d")!;
    const w = overlay.width;
    const h = overlay.height;
    const scale = renderScaleRef.current;

    // Redraw all existing annotations + current stroke
    drawOverlay();
    ctx.beginPath();
    ctx.strokeStyle = penColor;
    ctx.lineWidth = 2 * scale;
    ctx.lineCap = "round";
    ctx.lineJoin = "round";
    const pts = drawingPoints.current;
    ctx.moveTo(pts[0].x * w, pts[0].y * h);
    for (let i = 1; i < pts.length; i++) {
      ctx.lineTo(pts[i].x * w, pts[i].y * h);
    }
    ctx.stroke();
  };

  const handleMouseUp = () => {
    if (!isDrawing) return;
    setIsDrawing(false);
    if (drawingPoints.current.length > 1) {
      setAnnotations((prev) => [
        ...prev,
        {
          id: generateId(),
          type: "draw",
          x: 0,
          y: 0,
          color: penColor,
          points: [...drawingPoints.current],
        },
      ]);
    }
    drawingPoints.current = [];
  };

  // -----------------------------------------------------------------------
  // Undo
  // -----------------------------------------------------------------------

  const handleUndo = () => {
    setAnnotations((prev) => prev.slice(0, -1));
  };

  // -----------------------------------------------------------------------
  // Export annotated PDF
  // -----------------------------------------------------------------------

  const handleExport = useCallback(async () => {
    if (!pdfBytes || annotations.length === 0) return;
    setIsExporting(true);
    try {
      // Re-render the PDF page + overlay annotations onto a combined canvas
      const pdfjsLib = await getPdfjs();
      const pdf = await pdfjsLib.getDocument({ data: new Uint8Array(pdfBytes) }).promise;
      const pdfPage = await pdf.getPage(currentPage);

      // Use 2x base scale for export quality
      const baseViewport = pdfPage.getViewport({ scale: 1 });
      const exportScale = 2;
      const viewport = pdfPage.getViewport({ scale: exportScale });

      const expCanvas = document.createElement("canvas");
      expCanvas.width = Math.floor(viewport.width);
      expCanvas.height = Math.floor(viewport.height);
      const expCtx = expCanvas.getContext("2d")!;

      // 1) Render the PDF onto the export canvas
      await pdfPage.render({ canvasContext: expCtx, viewport, canvas: expCanvas } as never).promise;

      // 2) Draw annotations on top (same canvas)
      const w = expCanvas.width;
      const h = expCanvas.height;

      for (const ann of annotations) {
        if (ann.type === "text" && ann.text) {
          const px = ann.x * w;
          const py = ann.y * h;
          const fs = (ann.fontSize ?? 14) * exportScale;
          expCtx.font = `${fs}px sans-serif`;
          expCtx.fillStyle = ann.color ?? "#1e293b";
          expCtx.fillText(ann.text, px, py);
        }

        if (ann.type === "draw" && ann.points && ann.points.length > 1) {
          expCtx.beginPath();
          expCtx.strokeStyle = ann.color ?? "#1e293b";
          expCtx.lineWidth = 2 * exportScale;
          expCtx.lineCap = "round";
          expCtx.lineJoin = "round";
          const first = ann.points[0];
          expCtx.moveTo(first.x * w, first.y * h);
          for (let i = 1; i < ann.points.length; i++) {
            expCtx.lineTo(ann.points[i].x * w, ann.points[i].y * h);
          }
          expCtx.stroke();
        }
      }

      // 3) Convert the combined canvas to JPEG and build a single-page PDF
      const jpegDataUrl = expCanvas.toDataURL("image/jpeg", 0.92);
      const jpegBinary = atob(jpegDataUrl.split(",")[1]);
      const jpegBytes = new Uint8Array(jpegBinary.length);
      for (let i = 0; i < jpegBinary.length; i++) {
        jpegBytes[i] = jpegBinary.charCodeAt(i);
      }

      const doc = await PDFDocument.create();
      const jpegImage = await doc.embedJpg(jpegBytes);
      const page = doc.addPage([baseViewport.width, baseViewport.height]);
      page.drawImage(jpegImage, {
        x: 0,
        y: 0,
        width: baseViewport.width,
        height: baseViewport.height,
      });

      const exportedBytes = await doc.save();
      const blob = new Blob([new Uint8Array(exportedBytes)], { type: "application/pdf" });
      const url = URL.createObjectURL(blob);
      const a = document.createElement("a");
      a.href = url;
      a.download = "annotated_document.pdf";
      a.click();
      URL.revokeObjectURL(url);
    } finally {
      setIsExporting(false);
    }
  }, [pdfBytes, annotations, currentPage]);

  // -----------------------------------------------------------------------
  // UI
  // -----------------------------------------------------------------------

  const tools: { mode: ToolMode; icon: string; label: string }[] = [
    { mode: "text", icon: "pi-font", label: "Text" },
    { mode: "draw", icon: "pi-pencil", label: "Draw" },
  ];

  return (
    <section className="space-y-6">
      <div>
        <h1 className="text-3xl font-bold text-slate-900 dark:text-white">
          PDF Annotator
        </h1>
        <p className="mt-1 text-sm text-slate-500 dark:text-slate-400">
          Upload a PDF or generate a sample, then click anywhere to add text or draw freely.
        </p>
      </div>

      {/* Toolbar */}
      <div className="flex flex-wrap items-center gap-3 rounded-2xl border border-slate-200 bg-white p-4 shadow-sm dark:border-slate-700 dark:bg-slate-900">
        {/* File actions */}
        <input
          ref={fileInputRef}
          type="file"
          accept="application/pdf"
          className="hidden"
          onChange={(e) => void handleFileChange(e)}
        />
        <Button
          type="button"
          icon="pi pi-upload"
          label="Upload PDF"
          className="p-button-outlined p-button-sm"
          onClick={() => fileInputRef.current?.click()}
        />
        <Button
          type="button"
          icon="pi pi-file"
          label="Sample PDF"
          className="p-button-outlined p-button-sm"
          onClick={() => void handleGenerateSample()}
        />

        <div className="h-8 w-px bg-slate-200 dark:bg-slate-700" />

        {/* Tool selection */}
        {tools.map((t) => (
          <button
            key={t.mode}
            type="button"
            onClick={() => setTool(t.mode)}
            className={`flex items-center gap-1.5 rounded-lg px-3 py-2 text-sm font-medium transition ${
              tool === t.mode
                ? "bg-indigo-100 text-indigo-700 dark:bg-indigo-900/40 dark:text-indigo-300"
                : "text-slate-600 hover:bg-slate-100 dark:text-slate-400 dark:hover:bg-slate-800"
            }`}
          >
            <span className={`pi ${t.icon} text-sm`} aria-hidden="true" />
            {t.label}
          </button>
        ))}

        <div className="h-8 w-px bg-slate-200 dark:bg-slate-700" />

        {/* Color picker */}
        <label className="flex items-center gap-2 text-sm text-slate-600 dark:text-slate-400">
          Color
          <input
            type="color"
            value={penColor}
            onChange={(e) => setPenColor(e.target.value)}
            className="h-8 w-8 cursor-pointer rounded border border-slate-300 dark:border-slate-600"
          />
        </label>

        {/* Font size (text mode) */}
        {tool === "text" && (
          <label className="flex items-center gap-2 text-sm text-slate-600 dark:text-slate-400">
            Size
            <input
              type="number"
              min={8}
              max={72}
              value={fontSize}
              onChange={(e) => setFontSize(Number(e.target.value))}
              className="w-16 rounded-lg border border-slate-300 bg-white px-2 py-1 text-center text-sm dark:border-slate-600 dark:bg-slate-800 dark:text-slate-100"
            />
          </label>
        )}

        <div className="h-8 w-px bg-slate-200 dark:bg-slate-700" />

        {/* Undo / Export */}
        <Button
          type="button"
          icon="pi pi-undo"
          label="Undo"
          className="p-button-outlined p-button-sm p-button-secondary"
          disabled={annotations.length === 0}
          onClick={handleUndo}
        />
        <Button
          type="button"
          icon={isExporting ? "pi pi-spin pi-spinner" : "pi pi-download"}
          label="Export PDF"
          className="p-button-sm p-button-success"
          disabled={!pdfBytes || annotations.length === 0 || isExporting}
          onClick={() => void handleExport()}
        />

        {/* Annotation count */}
        {annotations.length > 0 && (
          <span className="rounded-full bg-indigo-100 px-2.5 py-0.5 text-xs font-semibold text-indigo-700 dark:bg-indigo-900/40 dark:text-indigo-300">
            {annotations.length} annotation{annotations.length > 1 ? "s" : ""}
          </span>
        )}
      </div>

      {/* Canvas area */}
      {pdfBytes ? (
        <div className="space-y-3" ref={containerRef}>
          {/* Page navigation */}
          {pageCount > 1 && (
            <div className="flex items-center justify-center gap-3 text-sm">
              <Button
                type="button"
                icon="pi pi-chevron-left"
                className="p-button-text p-button-sm"
                disabled={currentPage <= 1}
                onClick={() => setCurrentPage((p) => p - 1)}
              />
              <span className="text-slate-600 dark:text-slate-400">
                Page {currentPage} / {pageCount}
              </span>
              <Button
                type="button"
                icon="pi pi-chevron-right"
                className="p-button-text p-button-sm"
                disabled={currentPage >= pageCount}
                onClick={() => setCurrentPage((p) => p + 1)}
              />
            </div>
          )}

          {/* PDF + overlay */}
          <div className="flex justify-center overflow-auto">
            <div
              className="relative inline-block"
            >
              {/* PDF render layer */}
              <canvas ref={canvasRef} className="block rounded-xl shadow-sm" />

              {/* Annotation overlay */}
              <canvas
                ref={overlayRef}
                className="absolute top-0 left-0 block rounded-xl"
                style={{
                  cursor: tool === "text" ? "text" : tool === "draw" ? "crosshair" : "default",
                }}
                onClick={handleCanvasClick}
                onMouseDown={handleMouseDown}
                onMouseMove={handleMouseMove}
                onMouseUp={handleMouseUp}
                onMouseLeave={handleMouseUp}
              />

              {/* Inline text input */}
              {editingId && (
                <input
                  type="text"
                  autoFocus
                  value={editText}
                  onChange={(e) => setEditText(e.target.value)}
                  onBlur={handleTextCommit}
                  onKeyDown={(e) => {
                    if (e.key === "Enter") handleTextCommit();
                    if (e.key === "Escape") {
                      setAnnotations((prev) => prev.filter((a) => a.id !== editingId));
                      setEditingId(null);
                      setEditText("");
                    }
                  }}
                  className="absolute z-10 rounded border border-indigo-400 bg-white/90 px-1 py-0.5 text-sm outline-none dark:bg-slate-800/90 dark:text-white"
                  style={{
                    left: editPos.left,
                    top: editPos.top - 8,
                    fontSize,
                    color: penColor,
                    minWidth: 80,
                  }}
                />
              )}
            </div>
          </div>
        </div>
      ) : (
        /* Empty state */
        <div className="flex flex-col items-center justify-center gap-4 rounded-2xl border-2 border-dashed border-slate-200 bg-white py-32 dark:border-slate-700 dark:bg-slate-900">
          <span className="pi pi-file-pdf text-6xl text-slate-300 dark:text-slate-600" aria-hidden="true" />
          <p className="text-slate-400 dark:text-slate-500">
            Upload a PDF or click &quot;Sample PDF&quot; to get started
          </p>
        </div>
      )}
    </section>
  );
}
