import Link from "next/link";
import { LanguageSwitcher } from "@/components/common/LanguageSwitcher";

export function Navbar() {
  return (
    <header className="border-b border-slate-200 bg-white px-6 py-4">
      <nav className="flex items-center justify-between">
        <Link href="/" className="text-xl font-semibold text-slate-900">
          Next Core
        </Link>
        <div className="flex items-center gap-4 text-sm">
          <LanguageSwitcher />
        </div>
      </nav>
    </header>
  );
}
