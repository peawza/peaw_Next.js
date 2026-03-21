"use client";

import { Column } from "primereact/column";
import { DataTable } from "@/components/ui/DataTable";
import type { User } from "@/types";

type UserTableProps = {
  users: User[];
};

export function UserTable({ users }: UserTableProps) {
  return (
    <DataTable value={users} paginator rows={5} tableStyle={{ minWidth: "40rem" }}>
      <Column field="id" header="ID" />
      <Column field="name" header="Name" />
      <Column field="email" header="Email" />
      <Column field="role" header="Role" />
    </DataTable>
  );
}
