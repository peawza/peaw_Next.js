import Link from "next/link";

export function Sidebar() {
  return (
    <aside className="hidden w-64 border-r border-slate-200 bg-white p-4 md:block">
      <h2 className="mb-4 text-sm font-semibold uppercase tracking-wide text-slate-500">
        Navigation
      </h2>
      <ul className="space-y-2 text-sm">
        <li>
          <Link href="/dashboard" className="block rounded px-3 py-2 hover:bg-slate-100">
            Dashboard
          </Link>
        </li>
        <li>
          <Link href="/users" className="block rounded px-3 py-2 hover:bg-slate-100">
            Users
          </Link>
        </li>
      </ul>
    </aside>
  );
}
