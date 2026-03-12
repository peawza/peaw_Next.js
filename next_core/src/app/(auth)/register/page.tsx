import { redirect } from "next/navigation";
import { auth } from "@/auth";
import { isAccessTokenExpired } from "@/lib/authToken";
import { RegisterForm } from "@/components/features/auth/RegisterForm";

export default async function RegisterPage() {
  const session = await auth();
  const accessToken = session?.accessToken;

  if (accessToken && !isAccessTokenExpired(accessToken)) {
    redirect("/dashboard");
  }

  return (
    <main className="mx-auto flex min-h-screen w-full max-w-md flex-col justify-center gap-6 px-6 py-10">
      <h1 className="text-3xl font-bold">Create account</h1>
      <RegisterForm />
    </main>
  );
}
