import { UserInfoScreenNoSSR } from "@/components/features/users/UserInfoScreenNoSSR";

type UserDetailPageProps = {
  params: Promise<{ id: string }>;
};

export default async function UserDetailPage({ params }: UserDetailPageProps) {
  const { id } = await params;

  return <UserInfoScreenNoSSR userId={id} />;
}
