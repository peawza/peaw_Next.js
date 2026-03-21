"use client";

import dynamic from "next/dynamic";

type UserInfoScreenNoSSRProps = {
  userId: string;
};

const DynamicUserInfoScreen = dynamic(
  () =>
    import("@/components/features/users/UserInfoScreen").then(
      (module) => module.UserInfoScreen,
    ),
  {
    ssr: false,
    loading: () => (
      <section className="space-y-2">
        <h1 className="text-3xl font-bold">User Info</h1>
        <p className="text-slate-600 dark:text-slate-300">Loading...</p>
      </section>
    ),
  },
);

export function UserInfoScreenNoSSR({ userId }: UserInfoScreenNoSSRProps) {
  return <DynamicUserInfoScreen userId={userId} />;
}
