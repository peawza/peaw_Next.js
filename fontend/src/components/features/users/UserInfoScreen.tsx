"use client";

import { useCallback, useEffect, useMemo, useState } from "react";
import { useSession } from "next-auth/react";
import { useTranslation } from "react-i18next";
import { LoadingSpinner } from "@/components/common/LoadingSpinner";
import { Button } from "@/components/ui/Button";
import { PasswordField } from "@/components/ui/PasswordField";
import { changeUmsPassword, getUmsUserById } from "@/services/umsUserService";
import type { UmsChangePasswordResponse, UmsUserInfo } from "@/types";

type UserInfoScreenProps = {
  userId: string;
};

type ChangePasswordFormState = {
  oldPassword: string;
  confirmOldPassword: string;
  newPassword: string;
  confirmNewPassword: string;
};

const initialChangePasswordForm: ChangePasswordFormState = {
  oldPassword: "",
  confirmOldPassword: "",
  newPassword: "",
  confirmNewPassword: "",
};

function toText(value: unknown, yesLabel: string, noLabel: string): string {
  if (value === null || value === undefined || value === "") {
    return "-";
  }

  if (typeof value === "boolean") {
    return value ? yesLabel : noLabel;
  }

  return String(value);
}

function formatDateTime(value: string | Date | null, languageCode: string): string {
  if (!value) {
    return "-";
  }

  const date = value instanceof Date ? value : new Date(value);
  if (Number.isNaN(date.getTime())) {
    return String(value);
  }

  const locale = languageCode.toLowerCase().startsWith("th") ? "th-TH" : "en-US";
  return new Intl.DateTimeFormat(locale, {
    dateStyle: "medium",
    timeStyle: "short",
  }).format(date);
}

function isChangePasswordFailed(response: UmsChangePasswordResponse): boolean {
  if (!response.resultStatus) {
    return true;
  }

  const statusCode = response.data?.statusCode?.trim();
  if (statusCode && statusCode !== "200" && statusCode.toUpperCase() !== "SUCCESS") {
    return true;
  }

  const messageCode = response.data?.messageCode?.toUpperCase();
  if (messageCode?.endsWith("NOT_FOUND")) {
    return true;
  }

  return false;
}

function getInitials(firstName: string | null, lastName: string | null, userName: string): string {
  if (firstName && lastName) {
    return `${firstName[0]}${lastName[0]}`.toUpperCase();
  }
  if (firstName) {
    return firstName.slice(0, 2).toUpperCase();
  }
  return userName.slice(0, 2).toUpperCase();
}

function InfoRow({ icon, label, value }: { icon: string; label: string; value: string }) {
  return (
    <div className="flex items-start gap-3 py-3">
      <span
        className={`pi ${icon} mt-0.5 text-base text-indigo-500 dark:text-indigo-400`}
        aria-hidden="true"
      />
      <div className="min-w-0 flex-1">
        <p className="text-xs font-medium uppercase tracking-wider text-slate-400 dark:text-slate-500">
          {label}
        </p>
        <p className="mt-0.5 wrap-break-word text-sm font-medium text-slate-800 dark:text-slate-100">
          {value}
        </p>
      </div>
    </div>
  );
}

export function UserInfoScreen({ userId }: UserInfoScreenProps) {
  const { t, i18n } = useTranslation();
  const { data: session, status } = useSession();
  const [userInfo, setUserInfo] = useState<UmsUserInfo | null>(null);
  const [isFetchingUserInfo, setIsFetchingUserInfo] = useState(true);
  const [userInfoError, setUserInfoError] = useState<string | null>(null);

  const [passwordForm, setPasswordForm] = useState<ChangePasswordFormState>(
    initialChangePasswordForm,
  );
  const [isSubmittingPassword, setIsSubmittingPassword] = useState(false);
  const [passwordMessage, setPasswordMessage] = useState<string | null>(null);
  const [passwordError, setPasswordError] = useState<string | null>(null);
  const [showPasswordSection, setShowPasswordSection] = useState(false);

  const accessToken = session?.accessToken ?? null;
  const yesLabel = t("COMMON.Yes", { defaultValue: "Yes" });
  const noLabel = t("COMMON.No", { defaultValue: "No" });

  const resolvedUserId = useMemo(() => {
    if (userId === "me") {
      return session?.user?.id ?? "";
    }
    return userId;
  }, [userId, session?.user?.id]);

  const loadUserInfo = useCallback(async () => {
    if (!accessToken) {
      setIsFetchingUserInfo(false);
      setUserInfoError(t("UserInfo.Error.AccessTokenMissing", { defaultValue: "Access token is missing. Please sign in again." }));
      return;
    }

    if (!resolvedUserId) {
      setIsFetchingUserInfo(false);
      setUserInfoError(t("UserInfo.Error.UserIdMissing", { defaultValue: "User ID is missing." }));
      return;
    }

    setIsFetchingUserInfo(true);
    setUserInfoError(null);

    try {
      const response = await getUmsUserById(resolvedUserId, accessToken);

      if (!response.resultStatus || !response.data) {
        setUserInfo(null);
        setUserInfoError(response.resultMessage || t("UserInfo.Error.LoadFailed", { defaultValue: "Cannot load user info." }));
        return;
      }

      setUserInfo(response.data);
    } catch (error) {
      setUserInfo(null);
      setUserInfoError(
        error instanceof Error ? error.message : t("UserInfo.Error.LoadFailed", { defaultValue: "Cannot load user info." }),
      );
    } finally {
      setIsFetchingUserInfo(false);
    }
  }, [accessToken, resolvedUserId, t]);

  useEffect(() => {
    if (status === "loading") {
      return;
    }

    if (status !== "authenticated") {
      setIsFetchingUserInfo(false);
      setUserInfo(null);
      setUserInfoError(t("UserInfo.Error.SessionExpired", { defaultValue: "Session expired. Please sign in again." }));
      return;
    }

    void loadUserInfo();
  }, [status, loadUserInfo, t]);

  const handleSubmitChangePassword = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    setPasswordError(null);
    setPasswordMessage(null);

    if (!userInfo?.userName) {
      setPasswordError(t("ChangePassword.Error.UserNameUnavailable", { defaultValue: "User name is unavailable." }));
      return;
    }

    if (!accessToken) {
      setPasswordError(t("ChangePassword.Error.AccessTokenMissing", { defaultValue: "Access token is missing. Please sign in again." }));
      return;
    }

    if (!passwordForm.oldPassword || !passwordForm.newPassword) {
      setPasswordError(t("ChangePassword.Error.Required", { defaultValue: "Please fill old and new password." }));
      return;
    }

    if (passwordForm.oldPassword !== passwordForm.confirmOldPassword) {
      setPasswordError(t("ChangePassword.Error.ConfirmOldPassword", { defaultValue: "Old password and confirm old password do not match." }));
      return;
    }

    if (passwordForm.newPassword !== passwordForm.confirmNewPassword) {
      setPasswordError(t("ChangePassword.Error.ConfirmNewPassword", { defaultValue: "New password and confirm new password do not match." }));
      return;
    }

    setIsSubmittingPassword(true);

    try {
      const response = await changeUmsPassword(
        {
          UserName: userInfo.userName,
          OldPassword: passwordForm.oldPassword,
          NewPassword: passwordForm.newPassword,
        },
        accessToken,
      );

      if (isChangePasswordFailed(response)) {
        setPasswordError(
          response.data?.messageName ||
            response.resultMessage ||
            t("ChangePassword.Error.SubmitFailed", { defaultValue: "Change password failed." }),
        );
        return;
      }

      setPasswordMessage(
        response.resultMessage ||
          t("ChangePassword.Success", { defaultValue: "Password changed successfully." }),
      );
      setPasswordForm(initialChangePasswordForm);
    } catch (error) {
      setPasswordError(
        error instanceof Error
          ? error.message
          : t("ChangePassword.Error.SubmitFailed", { defaultValue: "Change password failed." }),
      );
    } finally {
      setIsSubmittingPassword(false);
    }
  };

  const displayName = useMemo(() => {
    if (!userInfo) return "";
    const parts = [userInfo.firstName, userInfo.lastName].filter(Boolean);
    return parts.length > 0 ? parts.join(" ") : userInfo.userName;
  }, [userInfo]);

  if (isFetchingUserInfo) {
    return <LoadingSpinner />;
  }

  return (
    <section className="space-y-6">
      {/* Error banner */}
      {userInfoError ? (
        <div className="flex items-center gap-3 rounded-xl border border-red-200 bg-red-50 px-4 py-3 dark:border-red-900 dark:bg-red-950/30">
          <span className="pi pi-exclamation-triangle text-red-500" aria-hidden="true" />
          <p className="text-sm text-red-600 dark:text-red-300">{userInfoError}</p>
        </div>
      ) : null}

      {userInfo ? (
        <>
          {/* Profile Header Card */}
          <div className="relative overflow-hidden rounded-2xl border border-slate-200 bg-white shadow-sm dark:border-slate-700 dark:bg-slate-900">
            {/* Gradient banner */}
            <div className="relative h-32 bg-linear-to-br from-indigo-500 via-purple-500 to-pink-500">
              <button
                type="button"
                className="absolute right-4 top-4 flex items-center gap-2 rounded-xl border border-white/30 bg-white/20 px-4 py-2 text-sm font-medium text-white backdrop-blur-sm transition-all hover:bg-white/30 hover:shadow-md active:scale-95"
                onClick={() => void loadUserInfo()}
              >
                <span className="pi pi-refresh text-sm" aria-hidden="true" />
                {t("COMMON.Refresh", { defaultValue: "Refresh" })}
              </button>
            </div>

            <div className="relative px-6 pb-6">
              {/* Avatar */}
              <div className="-mt-14 mb-4">
                <div className="flex h-24 w-24 items-center justify-center rounded-2xl border-4 border-white bg-linear-to-br from-indigo-600 to-purple-600 text-2xl font-bold text-white shadow-lg dark:border-slate-900">
                  {getInitials(userInfo.firstName, userInfo.lastName, userInfo.userName)}
                </div>
              </div>

              {/* Name & username */}
              <h1 className="text-2xl font-bold text-slate-900 dark:text-white">
                {displayName}
              </h1>
              {displayName !== userInfo.userName && (
                <p className="mt-0.5 text-sm text-slate-500 dark:text-slate-400">
                  @{userInfo.userName}
                </p>
              )}

              {/* Status badges */}
              <div className="mt-3 flex flex-wrap gap-2">
                {userInfo.activeFlag && (
                  <span className="inline-flex items-center gap-1.5 rounded-full bg-emerald-100 px-3 py-1 text-xs font-semibold text-emerald-700 dark:bg-emerald-900/40 dark:text-emerald-300">
                    <span className="h-1.5 w-1.5 rounded-full bg-emerald-500" />
                    {t("UserInfo.Active", { defaultValue: "Active" })}
                  </span>
                )}
                {userInfo.systemAdminFlag && (
                  <span className="inline-flex items-center gap-1.5 rounded-full bg-amber-100 px-3 py-1 text-xs font-semibold text-amber-700 dark:bg-amber-900/40 dark:text-amber-300">
                    <span className="pi pi-shield text-xs" aria-hidden="true" />
                    {t("UserInfo.SystemAdmin", { defaultValue: "System Admin" })}
                  </span>
                )}
              </div>
            </div>
          </div>

          {/* Info Cards Row */}
          <div className="grid gap-6 md:grid-cols-2">
            {/* Personal Info */}
            <div className="rounded-2xl border border-slate-200 bg-white p-6 shadow-sm dark:border-slate-700 dark:bg-slate-900">
              <div className="mb-4 flex items-center gap-2">
                <div className="flex h-8 w-8 items-center justify-center rounded-lg bg-indigo-100 dark:bg-indigo-900/40">
                  <span className="pi pi-user text-sm text-indigo-600 dark:text-indigo-400" aria-hidden="true" />
                </div>
                <h2 className="text-base font-semibold text-slate-900 dark:text-white">
                  {t("UserInfo.PersonalInfo", { defaultValue: "Personal Information" })}
                </h2>
              </div>
              <div className="divide-y divide-slate-100 dark:divide-slate-800">
                <InfoRow
                  icon="pi-id-card"
                  label={t("UserInfo.FirstName", { defaultValue: "First Name" })}
                  value={toText(userInfo.firstName, yesLabel, noLabel)}
                />
                <InfoRow
                  icon="pi-id-card"
                  label={t("UserInfo.LastName", { defaultValue: "Last Name" })}
                  value={toText(userInfo.lastName, yesLabel, noLabel)}
                />
                <InfoRow
                  icon="pi-envelope"
                  label={t("UserInfo.Email", { defaultValue: "Email" })}
                  value={toText(userInfo.email, yesLabel, noLabel)}
                />
                <InfoRow
                  icon="pi-phone"
                  label={t("UserInfo.PhoneNumber", { defaultValue: "Phone Number" })}
                  value={toText(userInfo.phoneNumber, yesLabel, noLabel)}
                />
              </div>
            </div>

            {/* Organization & Activity */}
            <div className="rounded-2xl border border-slate-200 bg-white p-6 shadow-sm dark:border-slate-700 dark:bg-slate-900">
              <div className="mb-4 flex items-center gap-2">
                <div className="flex h-8 w-8 items-center justify-center rounded-lg bg-purple-100 dark:bg-purple-900/40">
                  <span className="pi pi-building text-sm text-purple-600 dark:text-purple-400" aria-hidden="true" />
                </div>
                <h2 className="text-base font-semibold text-slate-900 dark:text-white">
                  {t("UserInfo.OrgAndActivity", { defaultValue: "Organization & Activity" })}
                </h2>
              </div>
              <div className="divide-y divide-slate-100 dark:divide-slate-800">
                <InfoRow
                  icon="pi-sitemap"
                  label={t("UserInfo.DepartmentCode", { defaultValue: "Department Code" })}
                  value={toText(userInfo.departmentCode, yesLabel, noLabel)}
                />
                <InfoRow
                  icon="pi-briefcase"
                  label={t("UserInfo.PositionCode", { defaultValue: "Position Code" })}
                  value={toText(userInfo.positionCode, yesLabel, noLabel)}
                />
                <InfoRow
                  icon="pi-sign-in"
                  label={t("UserInfo.LastLoginDate", { defaultValue: "Last Login Date" })}
                  value={formatDateTime(userInfo.lastLoginDate, i18n.language)}
                />
                <InfoRow
                  icon="pi-key"
                  label={t("UserInfo.LastUpdatePasswordDate", { defaultValue: "Last Update Password Date" })}
                  value={formatDateTime(userInfo.lastUpdatePasswordDate, i18n.language)}
                />
              </div>
            </div>
          </div>

          {/* Change Password Section */}
          <div className="rounded-2xl border border-slate-200 bg-white shadow-sm dark:border-slate-700 dark:bg-slate-900">
            <button
              type="button"
              className="flex w-full items-center justify-between px-6 py-4 text-left transition-colors hover:bg-slate-50 dark:hover:bg-slate-800/50"
              onClick={() => setShowPasswordSection((prev) => !prev)}
            >
              <div className="flex items-center gap-2">
                <div className="flex h-8 w-8 items-center justify-center rounded-lg bg-rose-100 dark:bg-rose-900/40">
                  <span className="pi pi-lock text-sm text-rose-600 dark:text-rose-400" aria-hidden="true" />
                </div>
                <h2 className="text-base font-semibold text-slate-900 dark:text-white">
                  {t("ChangePassword.Title", { defaultValue: "Change Password" })}
                </h2>
              </div>
              <span
                className={`pi ${showPasswordSection ? "pi-chevron-up" : "pi-chevron-down"} text-sm text-slate-400 transition-transform`}
                aria-hidden="true"
              />
            </button>

            {showPasswordSection && (
              <div className="border-t border-slate-200 px-6 pb-6 pt-4 dark:border-slate-700">
                <form className="grid grid-cols-1 gap-4 md:grid-cols-2" onSubmit={handleSubmitChangePassword}>
                  <PasswordField
                    label={t("ChangePassword.CurrentPassword", { defaultValue: "Current Password" })}
                    value={passwordForm.oldPassword}
                    onChange={(event) =>
                      setPasswordForm((prev) => ({
                        ...prev,
                        oldPassword: event.target.value,
                      }))
                    }
                    autoComplete="current-password"
                    required
                  />
                  <PasswordField
                    label={t("ChangePassword.ConfirmPassword", {
                      defaultValue: "Confirm Current Password",
                    })}
                    value={passwordForm.confirmOldPassword}
                    onChange={(event) =>
                      setPasswordForm((prev) => ({
                        ...prev,
                        confirmOldPassword: event.target.value,
                      }))
                    }
                    autoComplete="current-password"
                    required
                  />
                  <PasswordField
                    label={t("ChangePassword.NewPassword", { defaultValue: "New Password" })}
                    value={passwordForm.newPassword}
                    onChange={(event) =>
                      setPasswordForm((prev) => ({
                        ...prev,
                        newPassword: event.target.value,
                      }))
                    }
                    autoComplete="new-password"
                    required
                  />
                  <PasswordField
                    label={t("ChangePassword.ConfirmPassword", { defaultValue: "Confirm Password" })}
                    value={passwordForm.confirmNewPassword}
                    onChange={(event) =>
                      setPasswordForm((prev) => ({
                        ...prev,
                        confirmNewPassword: event.target.value,
                      }))
                    }
                    autoComplete="new-password"
                    required
                  />

                  {passwordError ? (
                    <div className="flex items-center gap-2 rounded-lg border border-red-200 bg-red-50 px-4 py-3 text-sm text-red-600 dark:border-red-900 dark:bg-red-950/30 dark:text-red-300 md:col-span-2">
                      <span className="pi pi-times-circle" aria-hidden="true" />
                      {passwordError}
                    </div>
                  ) : null}

                  {passwordMessage ? (
                    <div className="flex items-center gap-2 rounded-lg border border-emerald-200 bg-emerald-50 px-4 py-3 text-sm text-emerald-700 dark:border-emerald-900 dark:bg-emerald-950/30 dark:text-emerald-300 md:col-span-2">
                      <span className="pi pi-check-circle" aria-hidden="true" />
                      {passwordMessage}
                    </div>
                  ) : null}

                  <div className="flex justify-end md:col-span-2">
                    <Button
                      type="submit"
                      icon={isSubmittingPassword ? "pi pi-spin pi-spinner" : "pi pi-save"}
                      label={
                        isSubmittingPassword
                          ? t("COMMON.Submitting", { defaultValue: "Submitting..." })
                          : t("ChangePassword.Title", { defaultValue: "Change Password" })
                      }
                      disabled={isSubmittingPassword}
                    />
                  </div>
                </form>
              </div>
            )}
          </div>
        </>
      ) : null}
    </section>
  );
}
