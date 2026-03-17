"use client";

import Link from "next/link";
import { useState } from "react";
import { signIn } from "next-auth/react";
import { useRouter } from "next/navigation";
import {
  callJsonApi,
  hasDirectLoginPayload,
  readErrorMessage,
} from "@/lib/auth/authRequest";
import type { LoginPayload } from "@/types";

type LoginFormProps = {
  onSubmit?: (payload: LoginPayload) => void | Promise<void>;
};

type PreLoginApiResponse = {
  status: "success" | "verify_login_required" | "first_login_required" | "error";
  payload?: unknown;
  token?: string | null;
  username?: string;
  message?: string;
  error?: string;
};

const initialState: LoginPayload = {
  userName: "",
  password: "",
};

function BrandMark() {
  return (
    <svg viewBox="0 0 48 48" className="h-7 w-7" aria-hidden="true">
      <defs>
        <linearGradient id="login-brand-gradient" x1="8" y1="8" x2="40" y2="40" gradientUnits="userSpaceOnUse">
          <stop stopColor="#818CF8" />
          <stop offset="1" stopColor="#4F46E5" />
        </linearGradient>
      </defs>
      <path
        d="M10 28.4C14.2 22.4 20.1 20.1 27.3 21.4C30.5 22 33.2 23.5 35.4 25.7C39 29.2 42 29.7 44 27.3C40.5 34.3 34.3 36.8 25.5 34.9C21.5 34.1 18.1 32 15.2 28.8C13.7 27.2 11.9 27.1 10 28.4Z"
        fill="url(#login-brand-gradient)"
      />
      <path
        d="M4 19.8C8.5 13.9 14.2 11.7 21.2 13.1C24.4 13.7 27.2 15.2 29.4 17.4C32.9 20.8 36 21.3 38.6 18.9C34.8 25.8 28.7 28.2 20.3 26.4C16.3 25.6 12.8 23.5 10 20.2C8.4 18.4 6.4 18.3 4 19.8Z"
        fill="url(#login-brand-gradient)"
        opacity="0.92"
      />
    </svg>
  );
}

function GoogleIcon() {
  return (
    <svg viewBox="0 0 24 24" className="h-5 w-5" aria-hidden="true">
      <path
        d="M21.81 12.23C21.81 11.41 21.74 10.81 21.58 10.19H12.2V13.86H17.71C17.6 14.77 17.02 16.14 15.73 17.06L15.71 17.18L18.72 19.47L18.93 19.49C20.85 17.75 21.81 15.19 21.81 12.23Z"
        fill="#4285F4"
      />
      <path
        d="M12.2 21.9C14.9 21.9 17.17 21.03 18.93 19.49L15.73 17.06C14.87 17.65 13.72 18.06 12.2 18.06C9.55 18.06 7.3 16.32 6.48 13.91L6.36 13.92L3.23 16.3L3.19 16.41C4.94 19.81 8.29 21.9 12.2 21.9Z"
        fill="#34A853"
      />
      <path
        d="M6.48 13.91C6.26 13.29 6.13 12.62 6.13 11.93C6.13 11.24 6.26 10.57 6.47 9.95L6.47 9.82L3.3 7.4L3.19 7.45C2.47 8.86 2.05 10.36 2.05 11.93C2.05 13.5 2.47 15 3.19 16.41L6.48 13.91Z"
        fill="#FBBC05"
      />
      <path
        d="M12.2 5.8C14.11 5.8 15.4 6.6 16.14 7.26L19 4.53C17.16 2.86 14.9 1.85 12.2 1.85C8.29 1.85 4.94 3.95 3.19 7.45L6.47 9.95C7.3 7.54 9.55 5.8 12.2 5.8Z"
        fill="#EB4335"
      />
    </svg>
  );
}

function GitHubIcon() {
  return (
    <svg viewBox="0 0 24 24" className="h-5 w-5 fill-current" aria-hidden="true">
      <path d="M12 2C6.48 2 2 6.58 2 12.23C2 16.74 4.87 20.56 8.84 21.91C9.34 22 9.52 21.69 9.52 21.43C9.52 21.2 9.51 20.45 9.5 19.46C6.73 20.08 6.14 18.25 6.14 18.25C5.68 17.04 5.03 16.73 5.03 16.73C4.12 16.09 5.1 16.11 5.1 16.11C6.11 16.18 6.64 17.18 6.64 17.18C7.54 18.77 8.99 18.31 9.56 18.03C9.65 17.36 9.91 16.91 10.2 16.65C7.99 16.38 5.67 15.5 5.67 11.59C5.67 10.48 6.06 9.58 6.7 8.87C6.6 8.6 6.26 7.53 6.79 6.08C6.79 6.08 7.63 5.8 9.5 7.12C10.29 6.9 11.15 6.79 12 6.79C12.85 6.79 13.72 6.9 14.51 7.12C16.37 5.8 17.21 6.08 17.21 6.08C17.74 7.53 17.4 8.6 17.3 8.87C17.94 9.58 18.33 10.48 18.33 11.59C18.33 15.51 16 16.38 13.79 16.65C14.15 16.98 14.47 17.62 14.47 18.61C14.47 20.03 14.46 21.13 14.46 21.43C14.46 21.69 14.64 22 15.15 21.91C19.12 20.56 22 16.74 22 12.23C22 6.58 17.52 2 12 2Z" />
    </svg>
  );
}

export function LoginForm({ onSubmit }: LoginFormProps) {
  const router = useRouter();
  const [formData, setFormData] = useState<LoginPayload>(initialState);
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);
  const [rememberMe, setRememberMe] = useState(true);

  const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

    setIsSubmitting(true);
    setErrorMessage(null);

    try {
      if (onSubmit) {
        await onSubmit(formData);
        return;
      }

      const preLoginResult = await callJsonApi("/api/auth/prelogin", {
        UserName: formData.userName,
        Password: formData.password,
        Device: "web",
      });

      if (preLoginResult.status === "error") {
        setErrorMessage(
          readErrorMessage(preLoginResult.payload) ?? preLoginResult.message ?? "Invalid username or password",
        );
        return;
      }

      const preLoginBody = preLoginResult.payload as PreLoginApiResponse;

      if (preLoginBody.status === "verify_login_required") {
        if (!preLoginBody.token) {
          setErrorMessage("OTP verification is required but token is missing");
          return;
        }

        const params = new URLSearchParams({
          token: preLoginBody.token,
          username: preLoginBody.username || formData.userName,
        });
        router.push(`/confirm-otp?${params.toString()}`);
        return;
      }

      if (preLoginBody.status === "first_login_required") {
        if (!preLoginBody.token) {
          setErrorMessage("First login is required but token is missing");
          return;
        }

        const params = new URLSearchParams({
          token: preLoginBody.token,
          username: preLoginBody.username || formData.userName,
        });
        router.push(`/firstlogin?${params.toString()}`);
        return;
      }

      if (preLoginBody.status === "error") {
        setErrorMessage(preLoginBody.message || "Invalid username or password");
        return;
      }

      if (!hasDirectLoginPayload(preLoginBody.payload)) {
        setErrorMessage(
          readErrorMessage(preLoginBody.payload) ?? "Login API did not return a usable login payload",
        );
        return;
      }

      const result = await signIn("credentials", {
        mode: "direct",
        username: preLoginBody.username || formData.userName,
        loginPayload: JSON.stringify(preLoginBody.payload ?? {}),
        redirect: false,
      });

      if (result?.error) {
        setErrorMessage("Invalid username or password");
        return;
      }

      router.push("/");
      router.refresh();
    } catch {
      setErrorMessage("Unable to sign in. Please try again.");
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <div className="space-y-8 sm:space-y-10">
      <div className="space-y-5 sm:space-y-6">
        <div className="flex h-11 w-11 items-center justify-center rounded-2xl bg-white/5 ring-1 ring-white/10 backdrop-blur-sm sm:h-12 sm:w-12">
          <BrandMark />
        </div>

        <div className="space-y-3">
          <h1 className="text-[clamp(2rem,5vw,3rem)] font-semibold tracking-tight text-white">
            Sign in to your account
          </h1>
          
        </div>
      </div>

      <form className="space-y-5 sm:space-y-6" onSubmit={handleSubmit}>
        <div className="space-y-4 sm:space-y-5">
          <label className="block text-sm font-semibold text-slate-100">
            <span className="mb-2 block">Email address</span>
            <input
              type="text"
              value={formData.userName}
              onChange={(event) =>
                setFormData((prev) => ({
                  ...prev,
                  userName: event.target.value,
                }))
              }
              autoComplete="username"
              autoCapitalize="none"
              spellCheck={false}
              required
              className="h-12 w-full rounded-xl border border-white/[0.08] bg-white/[0.06] px-4 text-base text-white outline-none transition placeholder:text-slate-500 focus:border-indigo-400 focus:bg-white/10 focus:ring-4 focus:ring-indigo-500/15"
            />
          </label>

          <label className="block text-sm font-semibold text-slate-100">
            <span className="mb-2 block">Password</span>
            <input
              type="password"
              value={formData.password}
              onChange={(event) =>
                setFormData((prev) => ({
                  ...prev,
                  password: event.target.value,
                }))
              }
              autoComplete="current-password"
              required
              className="h-12 w-full rounded-xl border border-white/[0.08] bg-white/[0.06] px-4 text-base text-white outline-none transition placeholder:text-slate-500 focus:border-indigo-400 focus:bg-white/10 focus:ring-4 focus:ring-indigo-500/15"
            />
          </label>
        </div>

        {errorMessage ? (
          <p className="rounded-2xl border border-red-500/30 bg-red-500/10 px-4 py-3 text-sm text-red-100">
            {errorMessage}
          </p>
        ) : null}

        <div className="flex flex-col items-start gap-4 text-sm sm:flex-row sm:items-center sm:justify-between">
          <label className="inline-flex items-center gap-3 text-slate-400">
            <input
              type="checkbox"
              checked={rememberMe}
              onChange={(event) => setRememberMe(event.target.checked)}
              className="h-4 w-4 rounded border-white/[0.12] bg-white/[0.06] text-indigo-500 accent-indigo-500"
            />
            <span>Remember me</span>
          </label>

          <button type="button" className="font-semibold text-indigo-400 transition hover:text-indigo-300">
            Forgot password?
          </button>
        </div>

        <button
          type="submit"
          disabled={isSubmitting}
          className="inline-flex h-12 w-full items-center justify-center rounded-xl bg-[linear-gradient(90deg,#6366F1_0%,#7C3AED_100%)] px-5 text-base font-semibold text-white shadow-[0_12px_32px_rgba(99,102,241,0.35)] transition hover:brightness-110 disabled:cursor-not-allowed disabled:opacity-70"
        >
          {isSubmitting ? "Signing in..." : "Sign in"}
        </button>

     
      </form>
    </div>
  );
}
