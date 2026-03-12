"use client";

import { useState } from "react";
import { signIn } from "next-auth/react";
import { useRouter } from "next/navigation";
import { Button } from "@/components/ui/Button";
import { InputField } from "@/components/ui/InputField";

type ConfirmOtpFormProps = {
  token: string;
  username: string;
};

type OtpApiResponse = {
  status: "success" | "error";
  payload?: unknown;
  message?: string;
};

export function ConfirmOtpForm({ token, username }: ConfirmOtpFormProps) {
  const router = useRouter();
  const [otpCode, setOtpCode] = useState("");
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [isResending, setIsResending] = useState(false);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);
  const [infoMessage, setInfoMessage] = useState<string | null>(null);

  const handleVerify = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

    setIsSubmitting(true);
    setErrorMessage(null);
    setInfoMessage(null);

    try {
      const response = await fetch("/api/auth/otp/verify", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          Token: token,
          OtpCode: otpCode,
          Device: "web",
        }),
      });

      const body = (await response.json()) as OtpApiResponse;

      if (body.status === "error") {
        setErrorMessage(body.message || "OTP verification failed");
        return;
      }

      const signInResult = await signIn("credentials", {
        mode: "direct",
        username,
        loginPayload: JSON.stringify(body.payload ?? {}),
        redirect: false,
      });

      if (signInResult?.error) {
        setErrorMessage("OTP verified but cannot create session");
        return;
      }

      router.push("/");
      router.refresh();
    } catch {
      setErrorMessage("Unable to verify OTP. Please try again.");
    } finally {
      setIsSubmitting(false);
    }
  };

  const handleResend = async () => {
    setIsResending(true);
    setErrorMessage(null);
    setInfoMessage(null);

    try {
      const response = await fetch("/api/auth/otp/resend", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          Token: token,
        }),
      });

      const body = (await response.json()) as OtpApiResponse;

      if (body.status === "error") {
        setErrorMessage(body.message || "Cannot resend OTP");
        return;
      }

      setInfoMessage("OTP was resent successfully");
    } catch {
      setErrorMessage("Unable to resend OTP. Please try again.");
    } finally {
      setIsResending(false);
    }
  };

  return (
    <form className="space-y-4 rounded-lg border border-slate-200 bg-white p-6 dark:border-slate-700 dark:bg-slate-900" onSubmit={handleVerify}>
      <InputField label="Username" type="text" value={username} disabled />
      <InputField
        label="OTP Code"
        type="text"
        value={otpCode}
        onChange={(event) => setOtpCode(event.target.value)}
        required
      />

      {errorMessage ? (
        <p className="rounded-md border border-red-200 bg-red-50 px-3 py-2 text-sm text-red-600 dark:border-red-900 dark:bg-red-950/30 dark:text-red-300">
          {errorMessage}
        </p>
      ) : null}

      {infoMessage ? (
        <p className="rounded-md border border-emerald-200 bg-emerald-50 px-3 py-2 text-sm text-emerald-700 dark:border-emerald-900 dark:bg-emerald-950/30 dark:text-emerald-300">
          {infoMessage}
        </p>
      ) : null}

      <Button
        type="submit"
        label={isSubmitting ? "Verifying..." : "Confirm OTP"}
        className="w-full"
        disabled={isSubmitting}
      />

      <Button
        type="button"
        label={isResending ? "Resending..." : "Resend OTP"}
        className="w-full p-button-outlined"
        disabled={isResending}
        onClick={handleResend}
      />
    </form>
  );
}
