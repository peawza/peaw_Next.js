import type { User } from "@/types";

type UserCardProps = {
  user: User;
};

export function UserCard({ user }: UserCardProps) {
  return (
    <article className="rounded-lg border border-slate-200 bg-white p-4 shadow-sm dark:border-slate-700 dark:bg-slate-900">
      <h3 className="text-lg font-semibold">{user.name}</h3>
      <p className="text-sm text-slate-600 dark:text-slate-300">{user.email}</p>
      <p className="mt-2 text-xs uppercase tracking-wide text-slate-500 dark:text-slate-400">
        Role: {user.role}
      </p>
    </article>
  );
}
