"use client";

import { DataTable as PrimeDataTable } from "primereact/datatable";
import type { DataTableProps, DataTableValueArray } from "primereact/datatable";

export function DataTable<TValue extends DataTableValueArray>(
  props: DataTableProps<TValue>,
) {
  return <PrimeDataTable {...props} />;
}
