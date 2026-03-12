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

function InfoItem({ label, value }: { label: string; value: string }) {
  return (
    <div className="space-y-1 rounded-md border border-slate-200 bg-slate-50 p-3 dark:border-slate-700 dark:bg-slate-800/60">
      <p className="text-xs font-semibold uppercase tracking-wide text-slate-500 dark:text-slate-400">
        {label}
      </p>
      <p className="break-words text-sm text-slate-800 dark:text-slate-100">{value}</p>
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

  const userInfoItems = useMemo(() => {
    if (!userInfo) {
      return [];
    }

    return [
      // { label: "ID", value: toText(userInfo.id) },
      // { label: "User Number", value: toText(userInfo.userNumber) },
      {
        label: t("UserInfo.UserName", { defaultValue: "User Name" }),
        value: toText(userInfo.userName, yesLabel, noLabel),
      },
      {
        label: t("UserInfo.FirstName", { defaultValue: "First Name" }),
        value: toText(userInfo.firstName, yesLabel, noLabel),
      },
      {
        label: t("UserInfo.LastName", { defaultValue: "Last Name" }),
        value: toText(userInfo.lastName, yesLabel, noLabel),
      },
      {
        label: t("UserInfo.DepartmentCode", { defaultValue: "Department Code" }),
        value: toText(userInfo.departmentCode, yesLabel, noLabel),
      },
      {
        label: t("UserInfo.PositionCode", { defaultValue: "Position Code" }),
        value: toText(userInfo.positionCode, yesLabel, noLabel),
      },
      {
        label: t("UserInfo.Email", { defaultValue: "Email" }),
        value: toText(userInfo.email, yesLabel, noLabel),
      },
      {
        label: t("UserInfo.PhoneNumber", { defaultValue: "Phone Number" }),
        value: toText(userInfo.phoneNumber, yesLabel, noLabel),
      },
      // { label: "Language Code", value: toText(userInfo.languageCode) },
      // { label: "First Login", value: toText(userInfo.firstLoginFlag) },
      // { label: "Active", value: toText(userInfo.activeFlag) },
      // { label: "System Admin", value: toText(userInfo.systemAdminFlag) },
      // { label: "Create By", value: toText(userInfo.createBy) },
      // { label: "Create Date", value: formatDateTime(userInfo.createDate) },
      // { label: "Update By", value: toText(userInfo.updateBy) },
      // { label: "Update Date", value: formatDateTime(userInfo.updateDate) },
      {
        label: t("UserInfo.LastLoginDate", { defaultValue: "Last Login Date" }),
        value: formatDateTime(userInfo.lastLoginDate, i18n.language),
      },
      {
        label: t("UserInfo.LastUpdatePasswordDate", { defaultValue: "Last Update Password Date" }),
        value: formatDateTime(userInfo.lastUpdatePasswordDate, i18n.language),
      },
      // { label: "Active Date", value: formatDateTime(userInfo.activeDate) },
      // { label: "Inactive Date", value: formatDateTime(userInfo.inActiveDate) },
      // { label: "Remark", value: toText(userInfo.remark) },
    ];
  }, [i18n.language, noLabel, t, userInfo, yesLabel]);

  if (isFetchingUserInfo) {
    return <LoadingSpinner />;
  }

  return (
    <section className="space-y-6">
      <div className="space-y-4 rounded-lg border border-slate-200 bg-white p-6 dark:border-slate-700 dark:bg-slate-900">
        <div className="flex items-center justify-between gap-2">
          <h1 className="text-3xl font-bold">{t("UserInfo.Title", { defaultValue: "User Info" })}</h1>
          <Button
            type="button"
            label={t("COMMON.Refresh", { defaultValue: "Refresh" })}
            className="p-button-outlined p-button-sm"
            onClick={() => void loadUserInfo()}
          />
        </div>

        {userInfoError ? (
          <p className="rounded-md border border-red-200 bg-red-50 px-3 py-2 text-sm text-red-600 dark:border-red-900 dark:bg-red-950/30 dark:text-red-300">
            {userInfoError}
          </p>
        ) : null}

        {userInfo ? (
          <div className="grid gap-3 md:grid-cols-2 xl:grid-cols-3">
            {userInfoItems.map((item) => (
              <InfoItem key={item.label} label={item.label} value={item.value} />
            ))}
          </div>
        ) : null}
      </div>

      <div className="space-y-4 rounded-lg border border-slate-200 bg-white p-6 dark:border-slate-700 dark:bg-slate-900">
        <h2 className="text-2xl font-semibold">
          {t("ChangePassword.Title", { defaultValue: "Change Password" })}
        </h2>
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
            <p className="rounded-md border border-red-200 bg-red-50 px-3 py-2 text-sm text-red-600 dark:border-red-900 dark:bg-red-950/30 dark:text-red-300 md:col-span-2">
              {passwordError}
            </p>
          ) : null}

          {passwordMessage ? (
            <p className="rounded-md border border-emerald-200 bg-emerald-50 px-3 py-2 text-sm text-emerald-700 dark:border-emerald-900 dark:bg-emerald-950/30 dark:text-emerald-300 md:col-span-2">
              {passwordMessage}
            </p>
          ) : null}

          <div className="md:col-span-2">
            <div className="grid grid-cols-12">
              <div className="col-span-12 md:col-span-3 md:col-start-10">
                <Button
                  type="submit"
                  label={
                    isSubmittingPassword
                      ? t("COMMON.Submitting", { defaultValue: "Submitting..." })
                      : t("ChangePassword.Title", { defaultValue: "Change Password" })
                  }
                  className="w-full"
                  disabled={isSubmittingPassword}
                />
              </div>
            </div>
          </div>
        </form>
      </div>
    </section>
  );
}
