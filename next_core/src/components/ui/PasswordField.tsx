"use client";

import { useMemo, useState } from "react";
import { InputText } from "primereact/inputtext";
import type { InputTextProps } from "primereact/inputtext";

type PasswordFieldProps = Omit<InputTextProps, "type"> & {
  label?: string;
  id?: string;
};

export function PasswordField({ label, id, ...props }: PasswordFieldProps) {
  const [showPassword, setShowPassword] = useState(false);

  const inputId =
    id ?? props.name ?? (label ? label.toLowerCase().replace(/\s+/g, "-") : undefined);

  const inputClassName = useMemo(() => {
    const classes = ["w-full pr-10"];
    if (typeof props.className === "string" && props.className.trim() !== "") {
      classes.unshift(props.className);
    }
    return classes.join(" ");
  }, [props.className]);

  return (
    <div className="flex flex-col gap-2">
      {label ? (
        <label htmlFor={inputId} className="text-sm font-medium text-slate-700 dark:text-slate-300">
          {label}
        </label>
      ) : null}
      <div className="relative">
        <InputText
          id={inputId}
          type={showPassword ? "text" : "password"}
          {...props}
          className={inputClassName}
        />
        <button
          type="button"
          onClick={() => setShowPassword((prev) => !prev)}
          className="absolute top-1/2 right-3 -translate-y-1/2 text-slate-500 transition hover:text-slate-700 dark:text-slate-400 dark:hover:text-slate-200"
          aria-label={showPassword ? "Hide password" : "Show password"}
          title={showPassword ? "Hide password" : "Show password"}
          disabled={props.disabled}
        >
          <span className={`pi ${showPassword ? "pi-eye-slash" : "pi-eye"}`} aria-hidden="true" />
        </button>
      </div>
    </div>
  );
}
