import { redirect } from "next/navigation";

export default function ExampleUILayout({
  children,
}: Readonly<{ children: React.ReactNode }>) {
  if (process.env.NEXT_PUBLIC_SHOW_EXAMPLE_UI !== "true") {
    redirect("/");
  }

  return <>{children}</>;
}
