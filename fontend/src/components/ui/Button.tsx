"use client";

import { Button as PrimeButton } from "primereact/button";
import type { ButtonProps } from "primereact/button";

export function Button(props: ButtonProps) {
  return <PrimeButton {...props} />;
}
