import Link from "next/link";
import { LanguageSwitcher } from "@/components/common/LanguageSwitcher";
import { ThemeToggle } from "@/components/common/ThemeToggle";

export function Navbar() {
  return (
    <header className="border-b border-slate-200 bg-white px-6 py-4 dark:border-slate-700 dark:bg-slate-900">
      <nav className="flex items-center justify-between">
        <Link href="/" className="text-xl font-semibold text-slate-900 dark:text-slate-100">
          Next Core
        </Link>
        <div className="flex items-center gap-4 text-sm">
          <Link
            href="/users/me"
            className="inline-flex items-center gap-2 rounded-md border border-slate-200 bg-white px-2 py-1 text-xs font-semibold text-slate-700 transition hover:bg-slate-100 dark:border-slate-700 dark:bg-slate-800 dark:text-slate-200 dark:hover:bg-slate-700"
          >
            <span className="pi pi-user text-xs" aria-hidden="true" />
            User Info
          </Link>
          <ThemeToggle />
          <LanguageSwitcher />
        </div>
      </nav>
    </header>
  );
}
