"use client";

import { InputText } from "primereact/inputtext";
import type { InputTextProps } from "primereact/inputtext";

type InputFieldProps = InputTextProps & {
  label?: string;
  id?: string;
};

export function InputField({ label, id, ...props }: InputFieldProps) {
  const inputId =
    id ?? props.name ?? (label ? label.toLowerCase().replace(/\s+/g, "-") : undefined);

  return (
    <div className="flex flex-col gap-2">
      {label ? (
        <label htmlFor={inputId} className="text-sm font-medium text-slate-700 dark:text-slate-300">
          {label}
        </label>
      ) : null}
      <InputText id={inputId} {...props} />
    </div>
  );
}
