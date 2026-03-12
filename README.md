# 📁 Next.js Project Structure — Best Practice

**Stack:** Next.js 14 (App Router) + PrimeReact + Tailwind CSS + Axios

---

## 🗂️ โครงสร้างโฟลเดอร์

```
my-app/
├── public/                         # Static assets
│   ├── images/
│   ├── icons/
│   └── fonts/
│
├── src/
│   ├── app/                        # Next.js App Router (pages & layouts)
│   │   ├── (auth)/                 # Route Group: หน้า auth ไม่มี layout หลัก
│   │   │   ├── login/
│   │   │   │   └── page.tsx
│   │   │   └── register/
│   │   │       └── page.tsx
│   │   ├── (main)/                 # Route Group: หน้าหลักที่มี layout
│   │   │   ├── dashboard/
│   │   │   │   └── page.tsx
│   │   │   ├── users/
│   │   │   │   ├── page.tsx        # /users — list
│   │   │   │   └── [id]/
│   │   │   │       └── page.tsx    # /users/:id — detail
│   │   │   └── layout.tsx          # Layout สำหรับ (main) group
│   │   ├── api/                    # API Routes (Next.js backend)
│   │   │   └── [...]/
│   │   │       └── route.ts
│   │   ├── globals.css             # Global styles
│   │   ├── layout.tsx              # Root layout (HTML, providers)
│   │   └── page.tsx                # หน้า Home /
│   │
│   ├── components/                 # Reusable UI Components
│   │   ├── common/                 # ใช้ทั่วทั้งแอป
│   │   │   ├── Navbar.tsx
│   │   │   ├── Sidebar.tsx
│   │   │   ├── Footer.tsx
│   │   │   └── LoadingSpinner.tsx
│   │   ├── ui/                     # Base UI components (wrap PrimeReact)
│   │   │   ├── Button.tsx
│   │   │   ├── InputField.tsx
│   │   │   ├── DataTable.tsx
│   │   │   └── Modal.tsx
│   │   └── features/               # Components แยกตาม feature
│   │       ├── auth/
│   │       │   ├── LoginForm.tsx
│   │       │   └── RegisterForm.tsx
│   │       └── users/
│   │           ├── UserCard.tsx
│   │           └── UserTable.tsx
│   │
│   ├── hooks/                      # Custom React Hooks
│   │   ├── useAuth.ts
│   │   ├── useFetch.ts
│   │   └── useDebounce.ts
│   │
│   ├── services/                   # API calls ทั้งหมด (Axios)
│   │   ├── api.ts                  # Axios instance + interceptors
│   │   ├── authService.ts
│   │   └── userService.ts
│   │
│   ├── store/                      # Global State (Zustand / Redux)
│   │   ├── index.ts
│   │   ├── authStore.ts
│   │   └── userStore.ts
│   │
│   ├── types/                      # TypeScript type definitions
│   │   ├── index.ts
│   │   ├── auth.types.ts
│   │   └── user.types.ts
│   │
│   ├── utils/                      # Helper functions
│   │   ├── formatter.ts            # format date, number, currency
│   │   ├── validator.ts            # validation helpers
│   │   └── constants.ts            # app-wide constants
│   │
│   ├── lib/                        # Third-party library configs
│   │   └── axios.ts                # Axios base config
│   │
│   └── providers/                  # React Context Providers
│       ├── AppProviders.tsx        # รวม providers ทั้งหมด
│       └── PrimeReactProvider.tsx  # PrimeReact theme config
│
├── .env.local                      # Environment variables (local)
├── .env.example                    # ตัวอย่าง env
├── .eslintrc.json
├── .prettierrc
├── next.config.ts
├── tailwind.config.ts
├── tsconfig.json
└── package.json
```

---

## 📦 Installation

```bash
# 1. สร้างโปรเจ็ค Next.js
npx create-next-app@latest my-app \
  --typescript \
  --tailwind \
  --eslint \
  --app \
  --src-dir \
  --import-alias "@/*"

cd my-app

# 2. ติดตั้ง PrimeReact
npm install primereact primeicons

# 3. ติดตั้ง Axios
npm install axios

# 4. ติดตั้ง Zustand (state management แนะนำ)
npm install zustand

# 5. ติดตั้ง tailwindcss-primeui (optional: integrate PrimeReact + Tailwind)
npm install tailwindcss-primeui
```

---

## ⚙️ Configuration Files

### `tailwind.config.ts`
```ts
import type { Config } from "tailwindcss";

const config: Config = {
  content: [
    "./src/pages/**/*.{js,ts,jsx,tsx,mdx}",
    "./src/components/**/*.{js,ts,jsx,tsx,mdx}",
    "./src/app/**/*.{js,ts,jsx,tsx,mdx}",
  ],
  theme: {
    extend: {
      colors: {
        primary: "#3B82F6",
        secondary: "#64748B",
      },
    },
  },
  plugins: [require("tailwindcss-primeui")],
};

export default config;
```

### `src/app/globals.css`
```css
@tailwind base;
@tailwind components;
@tailwind utilities;

/* PrimeReact Theme */
@import "primereact/resources/themes/lara-light-blue/theme.css";
@import "primereact/resources/primereact.min.css";
@import "primeicons/primeicons.css";
```

### `src/app/layout.tsx` — Root Layout
```tsx
import type { Metadata } from "next";
import "./globals.css";
import { AppProviders } from "@/providers/AppProviders";

export const metadata: Metadata = {
  title: "My App",
  description: "Next.js + PrimeReact + Tailwind",
};

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="th">
      <body>
        <AppProviders>{children}</AppProviders>
      </body>
    </html>
  );
}
```

### `src/providers/AppProviders.tsx`
```tsx
"use client";

import { PrimeReactProvider } from "primereact/api";

export function AppProviders({ children }: { children: React.ReactNode }) {
  return (
    <PrimeReactProvider value={{ ripple: true }}>
      {children}
    </PrimeReactProvider>
  );
}
```

---

## 🌐 Axios Setup

### `src/lib/axios.ts`
```ts
import axios from "axios";

const axiosInstance = axios.create({
  baseURL: process.env.NEXT_PUBLIC_API_URL || "https://api.example.com",
  timeout: 10000,
  headers: {
    "Content-Type": "application/json",
  },
});

// Request Interceptor — แนบ token อัตโนมัติ
axiosInstance.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("token");
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => Promise.reject(error)
);

// Response Interceptor — จัดการ error กลาง
axiosInstance.interceptors.response.use(
  (response) => response,
  (error) => {
    if (error.response?.status === 401) {
      // redirect to login
      window.location.href = "/login";
    }
    return Promise.reject(error);
  }
);

export default axiosInstance;
```

### `src/services/userService.ts`
```ts
import axiosInstance from "@/lib/axios";
import { User } from "@/types/user.types";

export const userService = {
  getAll: () =>
    axiosInstance.get<User[]>("/users"),

  getById: (id: number) =>
    axiosInstance.get<User>(`/users/${id}`),

  create: (data: Partial<User>) =>
    axiosInstance.post<User>("/users", data),

  update: (id: number, data: Partial<User>) =>
    axiosInstance.put<User>(`/users/${id}`, data),

  delete: (id: number) =>
    axiosInstance.delete(`/users/${id}`),
};
```

---

## 🔑 Types

### `src/types/user.types.ts`
```ts
export interface User {
  id: number;
  name: string;
  email: string;
  role: "admin" | "user";
  createdAt: string;
}

export interface ApiResponse<T> {
  data: T;
  message: string;
  success: boolean;
}
```

---

## 🪝 Custom Hook

### `src/hooks/useFetch.ts`
```ts
import { useState, useEffect } from "react";
import axios, { AxiosRequestConfig } from "axios";
import axiosInstance from "@/lib/axios";

export function useFetch<T>(url: string, config?: AxiosRequestConfig) {
  const [data, setData] = useState<T | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const controller = new AbortController();

    axiosInstance
      .get<T>(url, { ...config, signal: controller.signal })
      .then((res) => setData(res.data))
      .catch((err) => {
        if (!axios.isCancel(err)) setError(err.message);
      })
      .finally(() => setLoading(false));

    return () => controller.abort();
  }, [url]);

  return { data, loading, error };
}
```

---

## 🌿 Environment Variables

### `.env.local`
```env
NEXT_PUBLIC_API_URL=https://api.example.com
NEXT_PUBLIC_APP_NAME=My App
```

### `.env.example`
```env
NEXT_PUBLIC_API_URL=
NEXT_PUBLIC_APP_NAME=
```

---

## ✅ Best Practices สรุป

| หัวข้อ | แนวทาง |
|--------|--------|
| **Folder Structure** | แยกตาม feature ไม่ใช่ตาม file type |
| **Components** | แยก `ui/` (base), `common/` (shared), `features/` (business) |
| **API Calls** | รวมใน `services/` เรียกผ่าน axios instance เดียว |
| **Types** | TypeScript ทุกที่, แยกไฟล์ใน `types/` |
| **State** | Zustand สำหรับ global, useState/useReducer สำหรับ local |
| **Env** | `NEXT_PUBLIC_` prefix สำหรับ client-side เท่านั้น |
| **Error Handling** | จัดการใน axios interceptor + try/catch ใน service |
