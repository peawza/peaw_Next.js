"use client";

import { PrimeReactAppProvider } from "@/providers/PrimeReactProvider";
import { ThemeProvider } from "@/providers/ThemeProvider";
import { SessionProvider } from "next-auth/react";

type AppProvidersProps = {
  children: React.ReactNode;
};

export function AppProviders({ children }: AppProvidersProps) {
  return (
    <ThemeProvider>
      <SessionProvider>
        <PrimeReactAppProvider>{children}</PrimeReactAppProvider>
      </SessionProvider>
    </ThemeProvider>
  );
}
