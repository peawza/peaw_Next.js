export type UmsApiResponse<T> = {
  resultStatus: boolean;
  resultCode: string;
  resultMessage: string;
  data: T;
};

export type UmsUserInfo = {
  id: string;
  userNumber: number;
  userName: string;
  firstName: string | null;
  lastName: string | null;
  departmentCode: string | null;
  positionCode: string | null;
  email: string | null;
  phoneNumber: string | null;
  remark: string | null;
  languageCode: string | null;
  createDate: string | Date | null;
  createBy: string | null;
  updateDate: string | Date | null;
  updateBy: string | null;
  firstLoginFlag: boolean;
  activeFlag: boolean;
  systemAdminFlag: boolean;
  passwordAge: number | null;
  lastLoginDate: string | Date | null;
  lastUpdatePasswordDate: string | Date | null;
  activeDate: string | Date | null;
  inActiveDate: string | Date | null;
};

export type UmsGetUserByIdResponse = UmsApiResponse<UmsUserInfo | null>;

export type UmsChangePasswordRequest = {
  UserName: string;
  OldPassword: string;
  NewPassword: string;
};

export type UmsChangePasswordData = {
  statusCode?: string;
  statusName?: string;
  messageCode?: string;
  messageName?: string;
  userName?: string | null;
};

export type UmsChangePasswordResponse = UmsApiResponse<UmsChangePasswordData | null>;
