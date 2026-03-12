"use client";

import { PrimeReactAppProvider } from "@/providers/PrimeReactProvider";

type AppProvidersProps = {
  children: React.ReactNode;
};

export function AppProviders({ children }: AppProvidersProps) {
  return <PrimeReactAppProvider>{children}</PrimeReactAppProvider>;
}
