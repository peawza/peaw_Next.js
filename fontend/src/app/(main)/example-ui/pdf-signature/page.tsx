"use client";

import { useState, useCallback } from "react";
import { PDFDocument, rgb, StandardFonts } from "pdf-lib";
import { SignaturePad } from "@/components/ui/SignaturePad";
import { Button } from "@/components/ui/Button";

// ---------------------------------------------------------------------------
// Types
// ---------------------------------------------------------------------------

type FormState = {
  title: string;
  content: string;
  signerName: string;
};

const initialForm: FormState = {
  title: "Sample Document",
  content:
    "This document certifies that the undersigned agrees to the terms and conditions outlined herein. By signing below, you acknowledge and accept all responsibilities described in this agreement.",
  signerName: "",
};

// ---------------------------------------------------------------------------
// PDF Generator
// ---------------------------------------------------------------------------

async function generateSignedPdf(form: FormState, signatureDataUrl: string): Promise<Uint8Array> {
  const pdfDoc = await PDFDocument.create();
  const page = pdfDoc.addPage([595, 842]); // A4
  const font = await pdfDoc.embedFont(StandardFonts.Helvetica);
  const fontBold = await pdfDoc.embedFont(StandardFonts.HelveticaBold);
  const { height } = page.getSize();

  const margin = 50;
  let y = height - margin;

  // Header line
  page.drawRectangle({
    x: margin,
    y: y - 4,
    width: 495,
    height: 3,
    color: rgb(0.31, 0.27, 0.9),
  });
  y -= 30;

  // Title
  page.drawText(form.title, {
    x: margin,
    y,
    size: 22,
    font: fontBold,
    color: rgb(0.1, 0.1, 0.1),
  });
  y -= 14;

  // Date
  const dateStr = new Intl.DateTimeFormat("en-US", {
    dateStyle: "long",
    timeStyle: "short",
  }).format(new Date());
  page.drawText(`Date: ${dateStr}`, {
    x: margin,
    y,
    size: 10,
    font,
    color: rgb(0.4, 0.4, 0.4),
  });
  y -= 30;

  // Divider
  page.drawLine({
    start: { x: margin, y },
    end: { x: 545, y },
    thickness: 0.5,
    color: rgb(0.8, 0.8, 0.8),
  });
  y -= 24;

  // Body text — word-wrap
  const maxWidth = 495;
  const fontSize = 12;
  const lineHeight = 18;
  const words = form.content.split(" ");
  let line = "";

  for (const word of words) {
    const testLine = line ? `${line} ${word}` : word;
    const testWidth = font.widthOfTextAtSize(testLine, fontSize);

    if (testWidth > maxWidth && line) {
      page.drawText(line, { x: margin, y, size: fontSize, font, color: rgb(0.15, 0.15, 0.15) });
      y -= lineHeight;
      line = word;
    } else {
      line = testLine;
    }
  }
  if (line) {
    page.drawText(line, { x: margin, y, size: fontSize, font, color: rgb(0.15, 0.15, 0.15) });
    y -= lineHeight;
  }

  y -= 30;

  // Signer name
  if (form.signerName) {
    page.drawText(`Signed by: ${form.signerName}`, {
      x: margin,
      y,
      size: 12,
      font: fontBold,
      color: rgb(0.1, 0.1, 0.1),
    });
    y -= 20;
  }

  // Embed signature image
  const sigBytes = await fetch(signatureDataUrl).then((r) => r.arrayBuffer());
  const sigImage = await pdfDoc.embedPng(sigBytes);
  const sigDims = sigImage.scale(0.5);
  const sigWidth = Math.min(sigDims.width, 200);
  const sigHeight = sigWidth * (sigDims.height / sigDims.width);

  page.drawImage(sigImage, {
    x: margin,
    y: y - sigHeight,
    width: sigWidth,
    height: sigHeight,
  });
  y -= sigHeight + 8;

  // Signature line
  page.drawLine({
    start: { x: margin, y },
    end: { x: margin + 200, y },
    thickness: 1,
    color: rgb(0.3, 0.3, 0.3),
  });
  y -= 14;
  page.drawText("Authorized Signature", {
    x: margin,
    y,
    size: 9,
    font,
    color: rgb(0.5, 0.5, 0.5),
  });

  return pdfDoc.save();
}

// ---------------------------------------------------------------------------
// Component
// ---------------------------------------------------------------------------

export default function PdfSignaturePage() {
  const [form, setForm] = useState<FormState>(initialForm);
  const [signatureDataUrl, setSignatureDataUrl] = useState<string | null>(null);
  const [isGenerating, setIsGenerating] = useState(false);
  const [previewUrl, setPreviewUrl] = useState<string | null>(null);

  const handleGenerate = useCallback(async () => {
    if (!signatureDataUrl) return;
    setIsGenerating(true);
    try {
      const pdfBytes = await generateSignedPdf(form, signatureDataUrl);
      const blob = new Blob([new Uint8Array(pdfBytes)], { type: "application/pdf" });
      const url = URL.createObjectURL(blob);
      setPreviewUrl(url);
    } finally {
      setIsGenerating(false);
    }
  }, [form, signatureDataUrl]);

  const handleDownload = useCallback(() => {
    if (!previewUrl) return;
    const a = document.createElement("a");
    a.href = previewUrl;
    a.download = `${form.title.replace(/\s+/g, "_")}_signed.pdf`;
    a.click();
  }, [previewUrl, form.title]);

  return (
    <section className="space-y-6">
      <div>
        <h1 className="text-3xl font-bold text-slate-900 dark:text-white">
          PDF Signature Demo
        </h1>
        <p className="mt-1 text-sm text-slate-500 dark:text-slate-400">
          Fill in the form, draw your signature, then generate a signed PDF document.
        </p>
      </div>

      <div className="grid gap-6 xl:grid-cols-2">
        {/* Left — Form + Signature */}
        <div className="space-y-6">
          {/* Document form */}
          <div className="rounded-2xl border border-slate-200 bg-white p-6 shadow-sm dark:border-slate-700 dark:bg-slate-900">
            <div className="mb-4 flex items-center gap-2">
              <div className="flex h-8 w-8 items-center justify-center rounded-lg bg-indigo-100 dark:bg-indigo-900/40">
                <span className="pi pi-file-edit text-sm text-indigo-600 dark:text-indigo-400" aria-hidden="true" />
              </div>
              <h2 className="text-base font-semibold text-slate-900 dark:text-white">
                Document Details
              </h2>
            </div>

            <div className="space-y-4">
              <div className="flex flex-col gap-1.5">
                <label htmlFor="doc-title" className="text-sm font-medium text-slate-700 dark:text-slate-300">
                  Title
                </label>
                <input
                  id="doc-title"
                  type="text"
                  value={form.title}
                  onChange={(e) => setForm((p) => ({ ...p, title: e.target.value }))}
                  className="rounded-lg border border-slate-300 bg-white px-3 py-2 text-sm text-slate-800 outline-none transition focus:border-indigo-500 focus:ring-2 focus:ring-indigo-500/20 dark:border-slate-600 dark:bg-slate-800 dark:text-slate-100"
                />
              </div>

              <div className="flex flex-col gap-1.5">
                <label htmlFor="doc-content" className="text-sm font-medium text-slate-700 dark:text-slate-300">
                  Content
                </label>
                <textarea
                  id="doc-content"
                  rows={4}
                  value={form.content}
                  onChange={(e) => setForm((p) => ({ ...p, content: e.target.value }))}
                  className="rounded-lg border border-slate-300 bg-white px-3 py-2 text-sm text-slate-800 outline-none transition focus:border-indigo-500 focus:ring-2 focus:ring-indigo-500/20 dark:border-slate-600 dark:bg-slate-800 dark:text-slate-100"
                />
              </div>

              <div className="flex flex-col gap-1.5">
                <label htmlFor="signer-name" className="text-sm font-medium text-slate-700 dark:text-slate-300">
                  Signer Name
                </label>
                <input
                  id="signer-name"
                  type="text"
                  value={form.signerName}
                  onChange={(e) => setForm((p) => ({ ...p, signerName: e.target.value }))}
                  placeholder="e.g. John Doe"
                  className="rounded-lg border border-slate-300 bg-white px-3 py-2 text-sm text-slate-800 outline-none transition focus:border-indigo-500 focus:ring-2 focus:ring-indigo-500/20 dark:border-slate-600 dark:bg-slate-800 dark:text-slate-100"
                />
              </div>
            </div>
          </div>

          {/* Signature pad */}
          <div className="rounded-2xl border border-slate-200 bg-white p-6 shadow-sm dark:border-slate-700 dark:bg-slate-900">
            <div className="mb-4 flex items-center gap-2">
              <div className="flex h-8 w-8 items-center justify-center rounded-lg bg-purple-100 dark:bg-purple-900/40">
                <span className="pi pi-pencil text-sm text-purple-600 dark:text-purple-400" aria-hidden="true" />
              </div>
              <h2 className="text-base font-semibold text-slate-900 dark:text-white">
                Draw Signature
              </h2>
            </div>

            <SignaturePad
              label=""
              onChange={setSignatureDataUrl}
              height={180}
            />
          </div>

          {/* Action buttons */}
          <div className="flex flex-wrap gap-3">
            <Button
              type="button"
              icon={isGenerating ? "pi pi-spin pi-spinner" : "pi pi-file-pdf"}
              label={isGenerating ? "Generating..." : "Generate PDF"}
              disabled={!signatureDataUrl || isGenerating}
              onClick={() => void handleGenerate()}
              className="p-button-raised"
            />
            {previewUrl && (
              <Button
                type="button"
                icon="pi pi-download"
                label="Download PDF"
                onClick={handleDownload}
                className="p-button-success p-button-raised"
              />
            )}
          </div>
        </div>

        {/* Right — PDF Preview */}
        <div className="rounded-2xl border border-slate-200 bg-white shadow-sm dark:border-slate-700 dark:bg-slate-900">
          <div className="flex items-center gap-2 border-b border-slate-200 px-6 py-4 dark:border-slate-700">
            <div className="flex h-8 w-8 items-center justify-center rounded-lg bg-emerald-100 dark:bg-emerald-900/40">
              <span className="pi pi-eye text-sm text-emerald-600 dark:text-emerald-400" aria-hidden="true" />
            </div>
            <h2 className="text-base font-semibold text-slate-900 dark:text-white">
              PDF Preview
            </h2>
          </div>

          <div className="p-4">
            {previewUrl ? (
              <iframe
                src={previewUrl}
                title="PDF Preview"
                className="h-175 w-full rounded-lg border border-slate-200 dark:border-slate-700"
              />
            ) : (
              <div className="flex h-175 flex-col items-center justify-center gap-3 rounded-lg border-2 border-dashed border-slate-200 bg-slate-50 dark:border-slate-700 dark:bg-slate-800/50">
                <span className="pi pi-file-pdf text-5xl text-slate-300 dark:text-slate-600" aria-hidden="true" />
                <p className="text-sm text-slate-400 dark:text-slate-500">
                  PDF preview will appear here after generation
                </p>
              </div>
            )}
          </div>
        </div>
      </div>
    </section>
  );
}
