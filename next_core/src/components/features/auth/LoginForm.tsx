"use client";

import { useState } from "react";
import { Button } from "@/components/ui/Button";
import { InputField } from "@/components/ui/InputField";
import type { LoginPayload } from "@/types";

type LoginFormProps = {
  onSubmit?: (payload: LoginPayload) => void | Promise<void>;
};

const initialState: LoginPayload = {
  email: "",
  password: "",
};

export function LoginForm({ onSubmit }: LoginFormProps) {
  const [formData, setFormData] = useState<LoginPayload>(initialState);

  const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    if (onSubmit) {
      await onSubmit(formData);
    }
  };

  return (
    <form className="space-y-4 rounded-lg border border-slate-200 bg-white p-6" onSubmit={handleSubmit}>
      <InputField
        label="Email"
        type="email"
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
      <Button type="submit" label="Sign in" className="w-full" />
    </form>
  );
}
