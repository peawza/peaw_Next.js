"use client";

import { useState } from "react";
import { Button } from "@/components/ui/Button";
import { InputField } from "@/components/ui/InputField";
import type { RegisterPayload } from "@/types";

type RegisterFormProps = {
  onSubmit?: (payload: RegisterPayload) => void | Promise<void>;
};

const initialState: RegisterPayload = {
  name: "",
  email: "",
  password: "",
};

export function RegisterForm({ onSubmit }: RegisterFormProps) {
  const [formData, setFormData] = useState<RegisterPayload>(initialState);

  const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    if (onSubmit) {
      await onSubmit(formData);
    }
  };

  return (
    <form className="space-y-4 rounded-lg border border-slate-200 bg-white p-6" onSubmit={handleSubmit}>
      <InputField
        label="Name"
        value={formData.name}
        onChange={(event) =>
          setFormData((prev) => ({
            ...prev,
            name: event.target.value,
          }))
        }
        required
      />
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
      <Button type="submit" label="Create account" className="w-full" />
    </form>
  );
}
