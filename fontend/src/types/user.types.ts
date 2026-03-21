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
