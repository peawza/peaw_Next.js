export interface AuthUser {
  id: string | number;
  name: string;
  email: string;
  role: "admin" | "user";
}

export interface LoginPayload {
  userName: string;
  password: string;
  languageCode?: string;
}

export interface RegisterPayload {
  name: string;
  email: string;
  password: string;
}

export interface AuthResponse {
  user: AuthUser;
  token: string;
}

export interface AuthState {
  user: AuthUser | null;
  token: string | null;
  isAuthenticated: boolean;
}

export interface BackendLoginResponse {
  Id: string;
  UserNumber: number;
  UserName: string;
  LanguageCode: string;
  DisplayName: string;
  Token: string;
  RefreshToken: string;
  CustomerID: number;
  PermissionScreen: string;
  Timeout: number;
}
