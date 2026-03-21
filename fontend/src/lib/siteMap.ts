export type SiteMapAttributes = {
  "main-menu"?: boolean;
  "child-screens"?: string[];
};

export type SiteMapNode = {
  objectId: string;
  title?: string;
  moduleName?: string;
  subModuleName?: string;
  iconClass?: string;
  href?: string;
  attributes: SiteMapAttributes;
  childNodes: SiteMapNode[];
};

export const siteMapNodes: SiteMapNode[] = [
  {
    objectId: "IMS000",
    moduleName: "Main Menu",
    iconClass: "pi pi-th-large",
    attributes: {
      "main-menu": true,
      "child-screens": ["PDB010", "UMS010"],
    },
    childNodes: [
      {
        objectId: "GRP_GENERAL",
        subModuleName: "General",
        attributes: {},
        childNodes: [
          {
            objectId: "PDB010",
            title: "Dashboard",
            href: "/dashboard",
            iconClass: "pi pi-home",
            attributes: { "main-menu": true },
            childNodes: [],
          },
          {
            objectId: "UMS010",
            title: "Users",
            href: "/users",
            iconClass: "pi pi-users",
            attributes: { "main-menu": true },
            childNodes: [],
          },
        ],
      },
    ],
  },
  {
    objectId: "RPT000",
    moduleName: "Reports",
    iconClass: "pi pi-chart-line",
    attributes: {
      "main-menu": true,
      "child-screens": ["RPT010"],
    },
    childNodes: [
      {
        objectId: "RPT010",
        title: "Report 010",
        href: "/dashboard",
        iconClass: "pi pi-file",
        attributes: { "main-menu": true },
        childNodes: [],
      },
    ],
  },
];
