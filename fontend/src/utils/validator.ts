import { format, isValid, parseISO } from "date-fns";
import { th, enUS } from "date-fns/locale";

// ─────────────────────────────────────────────
// 📅 Date Format Patterns (ตรงกับ legacy var)
// ─────────────────────────────────────────────
export const DATE_FORMATS = {
  DATE_TIME_PICKER:  "dd/MM/yyyy HH:mm",         // formatDateTimePicker
  DATE_PICKER:       "dd/MM/yyyy",               // formatDatePicker
  DATE_WITH_TIME:    "dd/MM/yyyy HH:mm:ss",      // formatDateWithTime
  DATE_EXPORT:       "yyyyMMddHHmmss",           // formatDateWithTime_export
  TIME:              "HH:mm",                    // formatTime
} as const;

export type DateFormatKey = keyof typeof DATE_FORMATS;

// ─────────────────────────────────────────────
// 🛠️ Helper — แปลง value เป็น Date object
// ─────────────────────────────────────────────
function toDate(value: string | Date): Date {
  if (value instanceof Date) return value;

  // ISO string เช่น "2024-01-15T10:30:00"
  const parsed = parseISO(value);
  if (isValid(parsed)) return parsed;

  // fallback
  const fallback = new Date(value);
  if (isValid(fallback)) return fallback;

  throw new Error(`[formatter] Invalid date value: "${value}"`);
}

// ─────────────────────────────────────────────
// 📅 formatDate — ใช้ pattern key
// ─────────────────────────────────────────────

/**
 * @example
 * formatDate(new Date(), "DATE_PICKER")        // "15/01/2024"
 * formatDate(new Date(), "DATE_TIME_PICKER")   // "15/01/2024 10:30"
 * formatDate(new Date(), "DATE_WITH_TIME")     // "15/01/2024 10:30:00"
 * formatDate(new Date(), "DATE_EXPORT")        // "20240115103000"
 * formatDate(new Date(), "TIME")               // "10:30"
 */
export function formatDate(
  value: string | Date,
  patternKey: DateFormatKey = "DATE_PICKER",
): string {
  try {
    const date    = toDate(value);
    const pattern = DATE_FORMATS[patternKey];
    return format(date, pattern);
  } catch {
    return "";
  }
}

/**
 * ใช้ custom pattern โดยตรง (ถ้าไม่อยากใช้ key)
 * @example
 * formatDateCustom(new Date(), "dd MMM yyyy")  // "15 Jan 2024"
 */
export function formatDateCustom(
  value: string | Date,
  pattern: string,
  locale: "th" | "en" = "th",
): string {
  try {
    const date       = toDate(value);
    const dateLocale = locale === "th" ? th : enUS;
    return format(date, pattern, { locale: dateLocale });
  } catch {
    return "";
  }
}

// ─────────────────────────────────────────────
// 🕐 Specific helpers (ชื่อตรงกับ legacy var)
// ─────────────────────────────────────────────

/** "15/01/2024 10:30" */
export const formatDateTimePicker = (value: string | Date) =>
  formatDate(value, "DATE_TIME_PICKER");

/** "15/01/2024" */
export const formatDatePicker = (value: string | Date) =>
  formatDate(value, "DATE_PICKER");

/** "15/01/2024 10:30:00" */
export const formatDateWithTime = (value: string | Date) =>
  formatDate(value, "DATE_WITH_TIME");

/** "20240115103000" — สำหรับ export ไฟล์ */
export const formatDateExport = (value: string | Date) =>
  formatDate(value, "DATE_EXPORT");

/** "10:30" */
export const formatTime = (value: string | Date) =>
  formatDate(value, "TIME");

// ─────────────────────────────────────────────
// 🔢 Number & Currency
// ─────────────────────────────────────────────

/**
 * @example
 * formatNumber(1234567)          // "1,234,567"
 * formatNumber(1234567, "en-US") // "1,234,567"
 */
export function formatNumber(
  value: number,
  locale = "th-TH",
): string {
  return new Intl.NumberFormat(locale).format(value);
}

/**
 * @example
 * formatCurrency(1500)                          // "฿1,500.00"
 * formatCurrency(1500, { currency: "USD" })     // "$1,500.00"
 * formatCurrency(1500, { locale: "en-US", currency: "USD" }) // "$1,500.00"
 */
export function formatCurrency(
  value: number,
  options: { locale?: string; currency?: string } = {},
): string {
  const locale   = options.locale   ?? "th-TH";
  const currency = options.currency ?? "THB";

  return new Intl.NumberFormat(locale, {
    style: "currency",
    currency,
  }).format(value);
}

/**
 * format ทศนิยม
 * @example
 * formatDecimal(1234.5678, 2)  // "1,234.57"
 */
export function formatDecimal(
  value: number,
  decimalPlaces = 2,
  locale = "th-TH",
): string {
  return new Intl.NumberFormat(locale, {
    minimumFractionDigits: decimalPlaces,
    maximumFractionDigits: decimalPlaces,
  }).format(value);
}