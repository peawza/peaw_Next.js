import type { User } from "@/types";

type UserCardProps = {
  user: User;
};

export function UserCard({ user }: UserCardProps) {
  return (
    <article className="rounded-lg border border-slate-200 bg-white p-4 shadow-sm">
      <h3 className="text-lg font-semibold">{user.name}</h3>
      <p className="text-sm text-slate-600">{user.email}</p>
      <p className="mt-2 text-xs uppercase tracking-wide text-slate-500">
        Role: {user.role}
      </p>
    </article>
  );
}
