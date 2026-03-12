"use client";

import { PrimeReactAppProvider } from "@/providers/PrimeReactProvider";
import { SessionProvider } from "next-auth/react";

type AppProvidersProps = {
  children: React.ReactNode;
};

export function AppProviders({ children }: AppProvidersProps) {
  return (
    <SessionProvider>
      <PrimeReactAppProvider>{children}</PrimeReactAppProvider>
    </SessionProvider>
  );
}
