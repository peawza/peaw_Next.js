import { UserTable } from "@/components/features/users/UserTable";
import type { User } from "@/types";

const demoUsers: User[] = [
  {
    id: 1,
    name: "Alice",
    email: "alice@example.com",
    role: "admin",
    createdAt: "2026-03-12T00:00:00.000Z",
  },
  {
    id: 2,
    name: "Bob",
    email: "bob@example.com",
    role: "user",
    createdAt: "2026-03-12T00:00:00.000Z",
  },
];

export default function UsersPage() {
  return (
    <section className="space-y-4">
      <h1 className="text-3xl font-bold">Users</h1>
      <UserTable users={demoUsers} />
    </section>
  );
}
