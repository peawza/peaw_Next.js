"use client";

import { useState } from "react";
import {
  CommandButton,
  ApplyButton,
  SearchButton,
  SaveButton,
  CloseButton,
  ExitFormButton,
  DeleteButton,
  RefreshButton,
  ClearButton,
  ResetButton,
  ImportButton,
  ExportButton,
  AddButton,
  NewButton,
  NewDocumentButton,
  CancelButton,
  DownloadButton,
  SubmitButton,
  ApproveButton,
  ReApproveButton,
  RejectButton,
  PrintButton,
  UploadButton,
  ScanButton,
  LoadDataButton,
  DeleteTabButton,
  WorkFlowHisButton,
} from "@/components/ui/CommandButton";

// ---------------------------------------------------------------------------
// Types
// ---------------------------------------------------------------------------

type ButtonDemo = {
  name: string;
  description: string;
  permission?: string;
  element: React.ReactNode;
};

// ---------------------------------------------------------------------------
// Code snippets
// ---------------------------------------------------------------------------

const codeBasicUsage = `import { SaveButton, DeleteButton, NewButton } from "@/components/ui/CommandButton";

// 1) แสดงเสมอ — ไม่ตรวจสิทธิ์
<SaveButton onClick={handleSave} />

// 2) ตรวจสิทธิ์ — ซ่อนถ้าไม่มีสิทธิ์ Delete (default: permissionBehavior="hide")
<DeleteButton objectId="SCR001" onClick={handleDelete} />

// 3) ตรวจสิทธิ์ — disable แทนซ่อน
<NewButton objectId="SCR001" permissionBehavior="disable" onClick={handleNew} />

// 4) เปลี่ยน label
<SaveButton label="บันทึกข้อมูล" onClick={handleSave} />`;

const codeHideViaJs = `import { useState } from "react";
import { SaveButton, DeleteButton } from "@/components/ui/CommandButton";

function MyForm() {
  const [isEditing, setIsEditing] = useState(false);

  return (
    <div className="flex gap-2">
      {/* ซ่อน/แสดงผ่าน state */}
      {isEditing && <SaveButton onClick={handleSave} />}

      {/* หรือ disable ผ่าน prop */}
      <DeleteButton disabled={!isEditing} onClick={handleDelete} />

      <button onClick={() => setIsEditing((v) => !v)}>
        {isEditing ? "Cancel" : "Edit"}
      </button>
    </div>
  );
}`;

const codePermissionBehavior = `import { SaveButton, DeleteButton } from "@/components/ui/CommandButton";

// permissionBehavior="hide" (default) — ปุ่มจะหายไปถ้าไม่มีสิทธิ์
<SaveButton objectId="SCR001" permissionBehavior="hide" />

// permissionBehavior="disable" — ปุ่มจะยังแสดงแต่กดไม่ได้
<DeleteButton objectId="SCR001" permissionBehavior="disable" />

// ไม่ระบุ objectId — ปุ่มจะแสดงเสมอ (ไม่เช็คสิทธิ์)
<SaveButton />`;

const codeCustomCommandButton = `import { CommandButton } from "@/components/ui/CommandButton";
import { PermissionFunctionCode } from "@/lib/permissions";

// สร้างปุ่ม custom ที่ตรวจสิทธิ์ Export
<CommandButton
  label="Generate Report"
  icon="pi pi-file-pdf"
  severity="danger"
  objectId="RPT010"
  functionCode={PermissionFunctionCode.Export}
  permissionBehavior="disable"
  onClick={handleGenerateReport}
/>`;

// ---------------------------------------------------------------------------
// Button data
// ---------------------------------------------------------------------------

const generalButtons: ButtonDemo[] = [
  { name: "SearchButton", description: "ค้นหาข้อมูล — ใช้กับฟอร์ม filter", element: <SearchButton /> },
  { name: "ApplyButton", description: "ยืนยันการตั้งค่า / ใช้ filter", element: <ApplyButton /> },
  { name: "RefreshButton", description: "โหลดข้อมูลใหม่", element: <RefreshButton /> },
  { name: "LoadDataButton", description: "โหลดข้อมูลตาม parameter", element: <LoadDataButton /> },
  { name: "ClearButton", description: "ล้างฟอร์ม filter", element: <ClearButton /> },
  { name: "ResetButton", description: "รีเซ็ตฟอร์มกลับค่าเริ่มต้น", element: <ResetButton /> },
  { name: "CloseButton", description: "ปิด dialog / modal", element: <CloseButton /> },
  { name: "ExitFormButton", description: "ออกจากฟอร์มกลับหน้ารายการ", element: <ExitFormButton /> },
  { name: "CancelButton", description: "ยกเลิกการทำรายการปัจจุบัน", element: <CancelButton /> },
];

const crudButtons: ButtonDemo[] = [
  { name: "NewButton", description: "สร้างรายการใหม่", permission: "New", element: <NewButton /> },
  { name: "AddButton", description: "เพิ่มรายการ (inline / sub-table)", permission: "New", element: <AddButton /> },
  { name: "NewDocumentButton", description: "สร้างเอกสารใหม่ (สีแดงเน้น)", permission: "New", element: <NewDocumentButton /> },
  { name: "SaveButton", description: "บันทึกข้อมูล", permission: "Edit", element: <SaveButton /> },
  { name: "DeleteButton", description: "ลบรายการ", permission: "Delete", element: <DeleteButton /> },
  { name: "DeleteTabButton", description: "ลบ tab / section", permission: "Delete", element: <DeleteTabButton /> },
];

const fileButtons: ButtonDemo[] = [
  { name: "ImportButton", description: "นำเข้าไฟล์ (Excel, CSV ฯลฯ)", element: <ImportButton /> },
  { name: "ExportButton", description: "ส่งออกข้อมูล", permission: "Export", element: <ExportButton /> },
  { name: "UploadButton", description: "อัปโหลดไฟล์แนบ", element: <UploadButton /> },
  { name: "DownloadButton", description: "ดาวน์โหลดไฟล์ / เอกสาร", element: <DownloadButton /> },
  { name: "PrintButton", description: "พิมพ์รายงาน / เอกสาร", permission: "Print", element: <PrintButton /> },
  { name: "ScanButton", description: "สแกน barcode / QR code", element: <ScanButton /> },
];

const workflowButtons: ButtonDemo[] = [
  { name: "SubmitButton", description: "ส่งเอกสารเข้า workflow", element: <SubmitButton /> },
  { name: "ApproveButton", description: "อนุมัติเอกสาร", element: <ApproveButton /> },
  { name: "ReApproveButton", description: "ส่งอนุมัติใหม่ (ถูกตีกลับ)", element: <ReApproveButton /> },
  { name: "RejectButton", description: "ปฏิเสธ / ไม่อนุมัติ", element: <RejectButton /> },
  { name: "WorkFlowHisButton", description: "ดูประวัติ workflow", element: <WorkFlowHisButton /> },
];

// ---------------------------------------------------------------------------
// Sub-components
// ---------------------------------------------------------------------------

function CodeBlock({ title, code }: { title: string; code: string }) {
  return (
    <div className="rounded-lg border border-slate-200 dark:border-slate-700">
      <div className="border-b border-slate-200 bg-slate-50 px-4 py-2 dark:border-slate-700 dark:bg-slate-800">
        <span className="text-sm font-semibold text-slate-700 dark:text-slate-300">{title}</span>
      </div>
      <pre className="overflow-x-auto p-4 text-xs leading-relaxed text-slate-700 dark:text-slate-300">
        {code}
      </pre>
    </div>
  );
}

function ButtonTable({ title, items }: { title: string; items: ButtonDemo[] }) {
  return (
    <div className="space-y-3">
      <h2 className="text-lg font-semibold text-slate-900 dark:text-slate-100">{title}</h2>
      <div className="overflow-x-auto rounded-lg border border-slate-200 dark:border-slate-700">
        <table className="w-full text-left text-sm">
          <thead className="border-b border-slate-200 bg-slate-50 dark:border-slate-700 dark:bg-slate-800">
            <tr>
              <th className="px-4 py-3 font-medium text-slate-700 dark:text-slate-300">Component</th>
              <th className="px-4 py-3 font-medium text-slate-700 dark:text-slate-300">Preview</th>
              <th className="px-4 py-3 font-medium text-slate-700 dark:text-slate-300">Permission</th>
              <th className="px-4 py-3 font-medium text-slate-700 dark:text-slate-300">คำอธิบาย</th>
            </tr>
          </thead>
          <tbody className="divide-y divide-slate-200 dark:divide-slate-700">
            {items.map((item) => (
              <tr key={item.name} className="bg-white dark:bg-slate-900">
                <td className="whitespace-nowrap px-4 py-3 font-mono text-xs text-indigo-600 dark:text-indigo-400">
                  {"<"}{item.name}{" />"}
                </td>
                <td className="px-4 py-3">{item.element}</td>
                <td className="px-4 py-3 text-xs text-slate-500 dark:text-slate-400">
                  {item.permission ?? "—"}
                </td>
                <td className="px-4 py-3 text-slate-600 dark:text-slate-300">{item.description}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

// ---------------------------------------------------------------------------
// Interactive Demo
// ---------------------------------------------------------------------------

function InteractiveDemo() {
  const [isVisible, setIsVisible] = useState(true);
  const [isDisabled, setIsDisabled] = useState(false);

  return (
    <div className="space-y-4 rounded-lg border border-slate-200 bg-white p-5 dark:border-slate-700 dark:bg-slate-900">
      <h2 className="text-lg font-semibold text-slate-900 dark:text-slate-100">
        Interactive Demo — Hide / Disable ผ่าน JS
      </h2>

      {/* Controls */}
      <div className="flex flex-wrap items-center gap-4">
        <label className="flex items-center gap-2 text-sm text-slate-700 dark:text-slate-300">
          <input
            type="checkbox"
            checked={isVisible}
            onChange={(e) => setIsVisible(e.target.checked)}
            className="accent-indigo-600"
          />
          Visible (show / hide)
        </label>
        <label className="flex items-center gap-2 text-sm text-slate-700 dark:text-slate-300">
          <input
            type="checkbox"
            checked={isDisabled}
            onChange={(e) => setIsDisabled(e.target.checked)}
            className="accent-indigo-600"
          />
          Disabled
        </label>
      </div>

      {/* Button preview */}
      <div className="flex min-h-12 flex-wrap items-center gap-3 rounded-md border border-dashed border-slate-300 p-4 dark:border-slate-600">
        {isVisible ? (
          <>
            <SaveButton disabled={isDisabled} onClick={() => alert("Save clicked")} />
            <DeleteButton disabled={isDisabled} onClick={() => alert("Delete clicked")} />
            <NewButton disabled={isDisabled} onClick={() => alert("New clicked")} />
            <ExportButton disabled={isDisabled} onClick={() => alert("Export clicked")} />
            <PrintButton disabled={isDisabled} onClick={() => alert("Print clicked")} />
          </>
        ) : (
          <span className="text-sm italic text-slate-400">ปุ่มถูกซ่อน (isVisible = false)</span>
        )}
      </div>

      {/* Code for this demo */}
      <CodeBlock
        title="Code สำหรับ demo นี้"
        code={`const [isVisible, setIsVisible] = useState(true);
const [isDisabled, setIsDisabled] = useState(false);

// ซ่อน/แสดงผ่าน conditional rendering
{isVisible && <SaveButton disabled={isDisabled} onClick={handleSave} />}
{isVisible && <DeleteButton disabled={isDisabled} onClick={handleDelete} />}
{isVisible && <NewButton disabled={isDisabled} onClick={handleNew} />}`}
      />
    </div>
  );
}

// ---------------------------------------------------------------------------
// Permission Demo
// ---------------------------------------------------------------------------

function PermissionDemo() {
  return (
    <div className="space-y-4 rounded-lg border border-slate-200 bg-white p-5 dark:border-slate-700 dark:bg-slate-900">
      <h2 className="text-lg font-semibold text-slate-900 dark:text-slate-100">
        Permission Demo — Hide / Disable ผ่าน permissionScreen
      </h2>

      <div className="space-y-3">
        <div className="flex flex-wrap items-center gap-3">
          <span className="w-44 text-sm text-slate-600 dark:text-slate-400">
            objectId ไม่มีสิทธิ์ + hide:
          </span>
          <CommandButton
            label="ปุ่มนี้จะหายไป"
            icon="pi pi-eye-slash"
            severity="secondary"
            objectId="FAKE_NO_PERM"
            permissionBehavior="hide"
          />
          <span className="text-xs italic text-slate-400">(ไม่แสดงเพราะไม่มีสิทธิ์)</span>
        </div>

        <div className="flex flex-wrap items-center gap-3">
          <span className="w-44 text-sm text-slate-600 dark:text-slate-400">
            objectId ไม่มีสิทธิ์ + disable:
          </span>
          <CommandButton
            label="ปุ่ม Disabled"
            icon="pi pi-lock"
            severity="secondary"
            objectId="FAKE_NO_PERM"
            permissionBehavior="disable"
          />
        </div>

        <div className="flex flex-wrap items-center gap-3">
          <span className="w-44 text-sm text-slate-600 dark:text-slate-400">
            ไม่ระบุ objectId:
          </span>
          <CommandButton
            label="แสดงเสมอ"
            icon="pi pi-check"
            severity="success"
          />
        </div>
      </div>
    </div>
  );
}

// ---------------------------------------------------------------------------
// Page
// ---------------------------------------------------------------------------

export default function ExampleUIPage() {
  return (
    <section className="space-y-8">
      {/* Header */}
      <div>
        <h1 className="text-3xl font-bold text-slate-900 dark:text-slate-100">
          Button Sample
        </h1>
        <p className="mt-1 text-slate-600 dark:text-slate-400">
          รวม CommandButton preset ทั้งหมด พร้อมตัวอย่าง action hide / disable ผ่าน JS และ permission
          &mdash; หน้านี้แสดงเฉพาะโหมด dev เท่านั้น
        </p>
      </div>

      {/* Interactive demo */}
      <InteractiveDemo />

      {/* Permission demo */}
      <PermissionDemo />

      {/* Code samples */}
      <div className="space-y-4">
        <h2 className="text-lg font-semibold text-slate-900 dark:text-slate-100">
          ตัวอย่าง Code
        </h2>
        <CodeBlock title="การใช้งานพื้นฐาน" code={codeBasicUsage} />
        <CodeBlock title="ซ่อน / Disable ปุ่มผ่าน JS state" code={codeHideViaJs} />
        <CodeBlock title="ซ่อน / Disable ผ่าน permissionBehavior" code={codePermissionBehavior} />
        <CodeBlock title="สร้าง CommandButton แบบ Custom" code={codeCustomCommandButton} />
      </div>

      {/* Button catalog */}
      <ButtonTable title="General / Navigation" items={generalButtons} />
      <ButtonTable title="CRUD" items={crudButtons} />
      <ButtonTable title="File / Import / Export" items={fileButtons} />
      <ButtonTable title="Workflow / Approval" items={workflowButtons} />
    </section>
  );
}
