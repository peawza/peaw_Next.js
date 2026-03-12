import Link from "next/link";
import { LanguageSwitcher } from "@/components/common/LanguageSwitcher";
import { ThemeToggle } from "@/components/common/ThemeToggle";

export function Navbar() {
  return (
    <header className="border-b border-slate-200 bg-white px-6 py-4 dark:border-slate-700 dark:bg-slate-900">
      <nav className="flex items-center justify-between">
        <Link href="" className="text-xl font-semibold text-slate-900 dark:text-slate-100">
          
        </Link>
        <div className="flex items-center gap-4 text-sm">
          <ThemeToggle />
          <LanguageSwitcher />
        </div>
      </nav>
    </header>
  );
}
