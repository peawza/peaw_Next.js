export function formatDate(value: string | Date, locale = "th-TH"): string {
  const date = value instanceof Date ? value : new Date(value);
  return new Intl.DateTimeFormat(locale, {
    dateStyle: "medium",
    timeStyle: "short",
  }).format(date);
}

export function formatNumber(value: number, locale = "th-TH"): string {
  return new Intl.NumberFormat(locale).format(value);
}

export function formatCurrency(
  value: number,
  options: { locale?: string; currency?: string } = {},
): string {
  const locale = options.locale ?? "th-TH";
  const currency = options.currency ?? "THB";

  return new Intl.NumberFormat(locale, {
    style: "currency",
    currency,
  }).format(value);
}
