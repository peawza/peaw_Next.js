export type LanguageCode = "en" | "th";

export type LocalizedResources = Record<string, unknown>;

export type SystemResourceItem = {
  ScreenCode: string;
  ObjectID: string;
  ResourcesEN: string;
  ResourcesTH: string;
  Remark?: string | null;
  CreateDate?: string | null;
  CreateBy?: string | null;
};

export type MessageResourceItem = {
  MessageCode: string;
  MessageType?: string | null;
  MessageNameEN: string;
  MessageNameTH: string;
  Remark?: string | null;
  CreateDate?: string | null;
  CreateBy?: string | null;
};

export type ScreenResourceModule = {
  ModuleCode: string;
  Module_EN: string;
  Module_TH: string;
  Seq: number;
  IconClass?: string | null;
};

export type ScreenResourceSubModule = {
  ModuleCode?: string | null;
  SubModuleCode: string;
  SubModule_EN: string;
  SubModule_TH: string;
  Seq: number;
  IconClass?: string | null;
};

export type ScreenResourceScreen = {
  ScreenId: string;
  Name_EN: string;
  Name_TH: string;
  FunctionCode?: number | null;
  ModuleCode?: string | null;
  ModuleSeq?: number | null;
  ModuleName_EN?: string | null;
  ModuleName_TH?: string | null;
  ModuleName_Seq?: number | null;
  ModuleName_IconClass?: string | null;
  SubModuleCode?: string | null;
  SubModuleSeq?: number | null;
  SubModuleName_EN?: string | null;
  SubModuleName_TH?: string | null;
  SubModule_IconClass?: string | null;
  Screen_IconClass?: string | null;
  Screen_MainMenuFlag?: boolean | null;
  Screen_PermissionFlag?: boolean | null;
  Screen_Seq?: number | null;
  PageTitleName_EN?: string | null;
  PageTitleName_TH?: string | null;
};

export type ScreenResourcesPayload = {
  Module: ScreenResourceModule[];
  SubModule: ScreenResourceSubModule[];
  Screen: ScreenResourceScreen[];
};

export type LocalizedResourcesDictionary = Record<string, SystemResourceItem>;
export type MessageResourcesDictionary = Record<string, MessageResourceItem>;

export type LocalizedResourceBundle = {
  resources: LocalizedResourcesDictionary;
  messages: MessageResourcesDictionary;
  screenResources: ScreenResourcesPayload;
  resourcesRaw: SystemResourceItem[];
  messagesRaw: MessageResourceItem[];
};
