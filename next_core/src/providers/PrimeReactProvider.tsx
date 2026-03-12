"use client";

import { PrimeReactProvider as PrimeProvider } from "primereact/api";

type PrimeReactAppProviderProps = {
  children: React.ReactNode;
};

export function PrimeReactAppProvider({
  children,
}: PrimeReactAppProviderProps) {
  return <PrimeProvider value={{ ripple: true }}>{children}</PrimeProvider>;
}
