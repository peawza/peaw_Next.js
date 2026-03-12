import { GlobalLoading } from "@/components/common/GlobalLoading";

type LocaleLayoutProps = {
  children: React.ReactNode;
  params: Promise<{ locale: string }>;
};

export default async function LocaleLayout({ children, params }: LocaleLayoutProps) {
  const { locale } = await params;

  return (
    <div data-locale={locale}>
      <GlobalLoading />
      {children}
    </div>
  );
}
