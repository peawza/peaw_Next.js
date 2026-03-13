import { redirect } from "next/navigation";
import { auth } from "@/auth";
import { FirstLoginForm } from "@/components/features/auth/FirstLoginForm";
import { isAccessTokenExpired } from "@/lib/authToken";

type FirstLoginPageProps = {
  searchParams: Promise<{
    token?: string;
    username?: string;
  }>;
};

export default async function FirstLoginPage({ searchParams }: FirstLoginPageProps) {
  const session = await auth();
  const accessToken = session?.accessToken;

  if (accessToken && !isAccessTokenExpired(accessToken)) {
    redirect("/dashboard");
  }

  const params = await searchParams;
  const token = params.token?.trim() ?? "";
  const username = params.username?.trim() ?? "";

  if (!token || !username) {
    redirect("/login");
  }

  return (
    <main className="mx-auto flex min-h-screen w-full max-w-md flex-col justify-center gap-6 px-6 py-10">
      <h1 className="text-3xl font-bold">First Login</h1>
      <FirstLoginForm token={token} username={username} />
    </main>
  );
}
