"use client";

import { createContext, useCallback, useContext, useEffect, useMemo, useState } from "react";

type Theme = "light" | "dark";

type ThemeContextValue = {
  theme: Theme;
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
  const storedTheme = window.localStorage.getItem(THEME_STORAGE_KEY);
  if (storedTheme === "light" || storedTheme === "dark") {
    return storedTheme;
  }
  return null;
}

function resolveInitialTheme(): Theme {
  const storedTheme = getStoredTheme();
  if (storedTheme) {
    return storedTheme;
  }
  return window.matchMedia("(prefers-color-scheme: dark)").matches ? "dark" : "light";
}

function getThemeFromDocument(): Theme | null {
  if (typeof document === "undefined") {
    return null;
  }
  const themeFromDocument = document.documentElement.getAttribute("data-theme");
  if (themeFromDocument === "light" || themeFromDocument === "dark") {
    return themeFromDocument;
  }
  return null;
}

export function ThemeProvider({ children }: { children: React.ReactNode }) {
  const [theme, setThemeState] = useState<Theme>(() => {
    if (typeof window === "undefined") {
      return "light";
    }
    return getThemeFromDocument() ?? resolveInitialTheme();
  });

  useEffect(() => {
    applyTheme(theme);
  }, [theme]);

  const setTheme = useCallback((nextTheme: Theme) => {
    setThemeState(nextTheme);
    applyTheme(nextTheme);
    window.localStorage.setItem(THEME_STORAGE_KEY, nextTheme);
  }, []);

  const toggleTheme = useCallback(() => {
    setThemeState((previousTheme) => {
      const nextTheme = previousTheme === "dark" ? "light" : "dark";
      applyTheme(nextTheme);
      window.localStorage.setItem(THEME_STORAGE_KEY, nextTheme);
      return nextTheme;
    });
  }, []);

  const contextValue = useMemo(
    () => ({
      theme,
      setTheme,
      toggleTheme,
    }),
    [theme, setTheme, toggleTheme],
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
