import { create } from "zustand";
import type { User } from "@/types";

type UserStore = {
  users: User[];
  selectedUser: User | null;
  setUsers: (users: User[]) => void;
  setSelectedUser: (user: User | null) => void;
  upsertUser: (user: User) => void;
  removeUser: (id: number) => void;
};

export const useUserStore = create<UserStore>((set) => ({
  users: [],
  selectedUser: null,
  setUsers: (users) => set({ users }),
  setSelectedUser: (selectedUser) => set({ selectedUser }),
  upsertUser: (user) =>
    set((state) => {
      const exists = state.users.some((item) => item.id === user.id);
      if (exists) {
        return {
          users: state.users.map((item) => (item.id === user.id ? user : item)),
        };
      }
      return {
        users: [...state.users, user],
      };
    }),
  removeUser: (id) =>
    set((state) => ({
      users: state.users.filter((item) => item.id !== id),
      selectedUser:
        state.selectedUser && state.selectedUser.id === id ? null : state.selectedUser,
    })),
}));
