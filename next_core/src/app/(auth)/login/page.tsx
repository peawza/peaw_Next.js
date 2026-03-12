import { LoginForm } from "@/components/features/auth/LoginForm";

export default function LoginPage() {
  return (
    <main className="mx-auto flex min-h-screen w-full max-w-md flex-col justify-center gap-6 px-6 py-10">
      <h1 className="text-3xl font-bold">Login</h1>
      <LoginForm />
    </main>
  );
}
