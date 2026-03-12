import type { DefaultSession } from "next-auth";

declare module "next-auth" {
  interface Session {
    user: DefaultSession["user"] & {
      id?: string;
    };
    accessToken?: string;
    refreshToken?: string;
    languageCode?: string;
    customerId?: number;
    permissionScreen?: string;
    timeout?: number;
    userNumber?: number;
  }

  interface User {
    id: string;
    userName: string;
    displayName: string;
    languageCode: string;
    accessToken: string;
    refreshToken: string;
    customerId: number;
    permissionScreen: string;
    timeout: number;
    userNumber: number;
  }
}

declare module "next-auth/jwt" {
  interface JWT {
    id?: string;
    userName?: string;
    displayName?: string;
    languageCode?: string;
    accessToken?: string;
    refreshToken?: string;
    customerId?: number;
    permissionScreen?: string;
    timeout?: number;
    userNumber?: number;
  }
}
