type UserDetailPageProps = {
  params: Promise<{ id: string }>;
};

export default async function UserDetailPage({ params }: UserDetailPageProps) {
  const { id } = await params;

  return (
    <section className="space-y-2">
      <h1 className="text-3xl font-bold">User Detail</h1>
      <p className="text-slate-600">User ID: {id}</p>
    </section>
  );
}
