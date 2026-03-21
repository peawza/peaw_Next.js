"use client";

import { useState } from "react";
import { signIn } from "next-auth/react";
import { useRouter } from "next/navigation";
import { Button } from "@/components/ui/Button";
import { InputField } from "@/components/ui/InputField";
import { callJsonApi, hasDirectLoginPayload, readErrorMessage } from "@/lib/auth/authRequest";

type FirstLoginFormProps = {
  token: string;
  username: string;
};

type FirstLoginApiResponse = {
  status: "success" | "error";
  payload?: unknown;
  message?: string;
};

export function FirstLoginForm({ token, username }: FirstLoginFormProps) {
  const router = useRouter();
  const [oldPassword, setOldPassword] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);

  const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

    if (newPassword !== confirmPassword) {
      setErrorMessage("New password and confirm password do not match");
      return;
    }

    setIsSubmitting(true);
    setErrorMessage(null);

    try {
      const response = await callJsonApi("/api/auth/firstlogin", {
        UserName: username,
        OldPassword: oldPassword,
        NewPassword: newPassword,
        Token: token,
      });

      if (response.status === "error") {
        setErrorMessage(readErrorMessage(response.payload) ?? response.message ?? "Cannot update password");
        return;
      }

      const body = response.payload as FirstLoginApiResponse;

      if (body.status === "error") {
        setErrorMessage(body.message || "Cannot update password");
        return;
      }

      if (!hasDirectLoginPayload(body.payload)) {
        setErrorMessage(
          readErrorMessage(body.payload) ?? "First login API did not return a usable login payload",
        );
        return;
      }

      const signInResult = await signIn("credentials", {
        mode: "direct",
        username,
        loginPayload: JSON.stringify(body.payload ?? {}),
        redirect: false,
      });

      if (signInResult?.error) {
        router.push("/login");
        return;
      }

      router.push("/");
      router.refresh();
    } catch {
      setErrorMessage("Unable to complete first login. Please try again.");
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <form className="space-y-4 rounded-lg border border-slate-200 bg-white p-6 dark:border-slate-700 dark:bg-slate-900" onSubmit={handleSubmit}>
      <InputField label="Username" type="text" value={username} disabled />
      <InputField
        label="Old Password"
        type="password"
        value={oldPassword}
        onChange={(event) => setOldPassword(event.target.value)}
        required
      />
      <InputField
        label="New Password"
        type="password"
        value={newPassword}
        onChange={(event) => setNewPassword(event.target.value)}
        required
      />
      <InputField
        label="Confirm New Password"
        type="password"
        value={confirmPassword}
        onChange={(event) => setConfirmPassword(event.target.value)}
        required
      />

      {errorMessage ? (
        <p className="rounded-md border border-red-200 bg-red-50 px-3 py-2 text-sm text-red-600 dark:border-red-900 dark:bg-red-950/30 dark:text-red-300">
          {errorMessage}
        </p>
      ) : null}

      <Button
        type="submit"
        label={isSubmitting ? "Submitting..." : "Submit"}
        className="w-full"
        disabled={isSubmitting}
      />
    </form>
  );
}


