"use client";

import { useState } from "react";
import { signIn } from "next-auth/react";
import { useRouter } from "next/navigation";
import { Button } from "@/components/ui/Button";
import { InputField } from "@/components/ui/InputField";
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
  email: "",
  password: "",
};

export function LoginForm({ onSubmit }: LoginFormProps) {
  const router = useRouter();
  const [formData, setFormData] = useState<LoginPayload>(initialState);
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);

  const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

    setIsSubmitting(true);
    setErrorMessage(null);

    try {
      if (onSubmit) {
        await onSubmit(formData);
        return;
      }

      const preLoginResponse = await fetch("/api/auth/prelogin", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          UserName: formData.email,
          Password: formData.password,
          Device: "web",
        }),
      });

      const preLoginBody = (await preLoginResponse.json()) as PreLoginApiResponse;

      if (preLoginBody.status === "verify_login_required") {
        if (!preLoginBody.token) {
          setErrorMessage("OTP verification is required but token is missing");
          return;
        }

        const params = new URLSearchParams({
          token: preLoginBody.token,
          username: preLoginBody.username || formData.email,
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
          username: preLoginBody.username || formData.email,
        });
        router.push(`/firstlogin?${params.toString()}`);
        return;
      }

      if (preLoginBody.status === "error") {
        setErrorMessage(preLoginBody.message || "Invalid username or password");
        return;
      }

      const result = await signIn("credentials", {
        mode: "direct",
        username: preLoginBody.username || formData.email,
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
    <form className="space-y-4 rounded-lg border border-slate-200 bg-white p-6" onSubmit={handleSubmit}>
      <InputField
        label="Username"
        type="text"
        value={formData.email}
        onChange={(event) =>
          setFormData((prev) => ({
            ...prev,
            email: event.target.value,
          }))
        }
        required
      />
      <InputField
        label="Password"
        type="password"
        value={formData.password}
        onChange={(event) =>
          setFormData((prev) => ({
            ...prev,
            password: event.target.value,
          }))
        }
        required
      />
      {errorMessage ? (
        <p className="rounded-md border border-red-200 bg-red-50 px-3 py-2 text-sm text-red-600">
          {errorMessage}
        </p>
      ) : null}
      <Button
        type="submit"
        label={isSubmitting ? "Signing in..." : "Sign in"}
        className="w-full"
        disabled={isSubmitting}
      />
    </form>
  );
}
