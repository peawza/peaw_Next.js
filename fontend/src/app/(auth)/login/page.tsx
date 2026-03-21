import Image from "next/image";
import { redirect } from "next/navigation";
import { auth } from "@/auth";
import { LoginForm } from "@/components/features/auth/LoginForm";
import { isAccessTokenExpired } from "@/lib/auth/authToken";

export default async function LoginPage() {
  const session = await auth();
  const accessToken = session?.accessToken;

  if (accessToken && !isAccessTokenExpired(accessToken)) {
    redirect("/");
  }

  return (
    <main className="min-h-dvh bg-[#030712] text-white">
      <div className="grid min-h-dvh grid-cols-1 lg:grid-cols-[minmax(0,1.08fr)_minmax(420px,0.92fr)]">
        <aside className="order-2 relative min-h-[30svh] overflow-hidden border-t border-white/10 bg-[#e9eef2] sm:min-h-[36svh] lg:order-1 lg:min-h-dvh lg:border-t-0">
          <Image
            src="/images/login-workspace.svg"
            alt="Workspace illustration"
            fill
            priority
            className="object-cover"
            sizes="(min-width: 1024px) 55vw, 100vw"
          />

          <div className="absolute inset-0 bg-[linear-gradient(180deg,rgba(255,255,255,0.08)_0%,rgba(255,255,255,0.02)_34%,rgba(3,7,18,0.18)_100%)]" />
          <div className="absolute inset-0 bg-[radial-gradient(circle_at_top_left,rgba(255,255,255,0.36),transparent_26%),radial-gradient(circle_at_bottom_right,rgba(15,23,42,0.24),transparent_26%)]" />

          {/* <div className="absolute inset-x-4 bottom-4 hidden rounded-3xl border border-white/30 bg-white/30 p-5 text-slate-900 backdrop-blur-md sm:block md:inset-x-6 md:bottom-6 md:max-w-sm lg:bottom-8 lg:left-8 lg:right-auto">
            <p className="text-xs font-semibold uppercase tracking-[0.32em] text-slate-600">
              Flexible Workspace
            </p>
            <p className="mt-3 text-xl font-semibold tracking-tight text-slate-950">
              Clean, focused login experience for desktop and mobile.
            </p>
          </div> */}
        </aside>

        <section className="order-1 relative flex min-h-[70svh] items-center justify-center overflow-hidden bg-[radial-gradient(circle_at_top_left,_rgba(99,102,241,0.22),_transparent_28%),radial-gradient(circle_at_bottom_right,_rgba(59,130,246,0.12),_transparent_24%),linear-gradient(180deg,#06101f_0%,#08162d_100%)] px-4 py-8 sm:px-6 sm:py-10 md:px-10 lg:order-2 lg:min-h-dvh lg:border-l lg:border-white/10 lg:px-14 xl:px-20">
          <div className="absolute left-0 top-0 h-56 w-56 -translate-x-1/3 -translate-y-1/3 rounded-full bg-indigo-500/12 blur-3xl" />
          <div className="absolute bottom-0 right-0 h-64 w-64 translate-x-1/3 translate-y-1/3 rounded-full bg-sky-400/10 blur-3xl" />
          <div className="relative w-full max-w-[420px]">
            <LoginForm />
          </div>
        </section>
      </div>
    </main>
  );
}
