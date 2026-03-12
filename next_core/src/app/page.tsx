import Link from "next/link";

export default function HomePage() {
  return (
    <main className="mx-auto flex min-h-screen max-w-4xl flex-col justify-center gap-6 px-6 py-12">
      <h1 className="text-4xl font-bold">Next Core Starter</h1>
      <p className="text-lg text-slate-600">
        โครงสร้างโปรเจกต์เริ่มต้นพร้อม App Router, PrimeReact, Tailwind CSS และ Axios
      </p>

      <div className="flex flex-wrap gap-3">
        <Link
          href="/login"
          className="rounded-md bg-slate-900 px-4 py-2 text-white transition hover:bg-slate-700"
        >
          Login
        </Link>
        <Link
          href="/register"
          className="rounded-md border border-slate-300 px-4 py-2 transition hover:bg-slate-100"
        >
          Register
        </Link>
        <Link
          href="/dashboard"
          className="rounded-md border border-slate-300 px-4 py-2 transition hover:bg-slate-100"
        >
          Dashboard
        </Link>
      </div>
    </main>
  );
}
