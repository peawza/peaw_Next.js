import { redirect } from "next/navigation";
import { auth } from "@/auth";
import { isAccessTokenExpired } from "@/lib/authToken";

export default async function HomePage() {
  const session = await auth();
  const accessToken = session?.accessToken;

  if (!accessToken || isAccessTokenExpired(accessToken)) {
    redirect("/login");
  }

  redirect("/dashboard");
}
