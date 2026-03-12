"use client";

import { createContext, useCallback, useContext, useEffect, useMemo } from "react";

type Theme = "light" | "dark";

type ThemeContextValue = {
  setTheme: (theme: Theme) => void;
  toggleTheme: () => void;
};

const THEME_STORAGE_KEY = "next-core-theme";

const ThemeContext = createContext<ThemeContextValue | undefined>(undefined);

function applyTheme(theme: Theme): void {
  const rootElement = document.documentElement;
  rootElement.classList.toggle("dark", theme === "dark");
  rootElement.setAttribute("data-theme", theme);
  rootElement.style.colorScheme = theme;
}

function getStoredTheme(): Theme | null {
  if (typeof window === "undefined") {
    return null;
  }
  const storedTheme = window.localStorage.getItem(THEME_STORAGE_KEY);
  if (storedTheme === "light" || storedTheme === "dark") {
    return storedTheme;
  }
  return null;
}

function resolvePreferredTheme(): Theme {
  const storedTheme = getStoredTheme();
  if (storedTheme) {
    return storedTheme;
  }
  if (typeof window === "undefined") {
    return "light";
  }
  return window.matchMedia("(prefers-color-scheme: dark)").matches ? "dark" : "light";
}

function getThemeFromDocument(): Theme {
  if (typeof document === "undefined") {
    return "light";
  }
  const themeFromDocument = document.documentElement.getAttribute("data-theme");
  if (themeFromDocument === "light" || themeFromDocument === "dark") {
    return themeFromDocument;
  }
  return document.documentElement.classList.contains("dark") ? "dark" : "light";
}

export function ThemeProvider({ children }: { children: React.ReactNode }) {
  useEffect(() => {
    applyTheme(resolvePreferredTheme());
  }, []);

  const setTheme = useCallback((nextTheme: Theme) => {
    applyTheme(nextTheme);
    window.localStorage.setItem(THEME_STORAGE_KEY, nextTheme);
  }, []);

  const toggleTheme = useCallback(() => {
    const currentTheme = getThemeFromDocument();
    const nextTheme: Theme = currentTheme === "dark" ? "light" : "dark";
    applyTheme(nextTheme);
    window.localStorage.setItem(THEME_STORAGE_KEY, nextTheme);
  }, []);

  const contextValue = useMemo(
    () => ({
      setTheme,
      toggleTheme,
    }),
    [setTheme, toggleTheme],
  );

  return <ThemeContext.Provider value={contextValue}>{children}</ThemeContext.Provider>;
}

export function useTheme(): ThemeContextValue {
  const context = useContext(ThemeContext);
  if (!context) {
    throw new Error("useTheme must be used within ThemeProvider");
  }
  return context;
}
