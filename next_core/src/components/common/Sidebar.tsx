"use client";

import Link from "next/link";
import { usePathname } from "next/navigation";
import { signOut } from "next-auth/react";
import { useCallback, useMemo, useState } from "react";
import { PermissionNames } from "@/lib/permissions";
import { siteMapNodes, type SiteMapNode } from "@/lib/siteMap";
import { useHasPermission } from "@/hooks/usePermission";

const showExampleUI = process.env.NEXT_PUBLIC_SHOW_EXAMPLE_UI === "true";

function hasMainMenu(node: SiteMapNode): boolean {
  return node.attributes["main-menu"] === true;
}

function getChildScreens(node: SiteMapNode): string[] {
  return node.attributes["child-screens"] ?? [];
}

function hasPermissionForNode(node: SiteMapNode, hasPermission: (objectId: string) => boolean): boolean {
  const childScreens = getChildScreens(node);
  if (childScreens.length > 0) {
    return childScreens.some((screen) => hasPermission(screen));
  }
  return hasPermission(node.objectId);
}

function hasChildPermission(
  parent: SiteMapNode,
  hasPermission: (objectId: string) => boolean,
): boolean {
  return parent.childNodes.some((node) => hasPermissionForNode(node, hasPermission));
}

function hasScreenPermission(
  objectId: string,
  hasPermission: (objectId: string) => boolean,
): boolean {
  return hasPermission(objectId);
}

function isPathActive(pathname: string, href?: string): boolean {
  if (!href) {
    return false;
  }
  if (href === "/") {
    return pathname === "/";
  }
  return pathname === href || pathname.startsWith(`${href}/`);
}

function hasActiveDescendant(
  node: SiteMapNode,
  pathname: string,
): boolean {
  if (isPathActive(pathname, node.href)) {
    return true;
  }
  return node.childNodes.some((child) => hasActiveDescendant(child, pathname));
}

export function Sidebar() {
  const pathname = usePathname();
  const hasPermission = useHasPermission();
  const [openNodeMap, setOpenNodeMap] = useState<Record<string, boolean>>({});

  const canView = useCallback(
    (objectId: string) => hasPermission(objectId, PermissionNames.View.FunctionCode),
    [hasPermission],
  );

  const visibleMainMenus = useMemo(
    () =>
      siteMapNodes.filter((node) => {
        if (!hasMainMenu(node)) {
          return false;
        }
        return hasPermissionForNode(node, canView);
      }),
    [canView],
  );

  const isOpen = useCallback(
    (node: SiteMapNode) => openNodeMap[node.objectId] ?? hasActiveDescendant(node, pathname),
    [openNodeMap, pathname],
  );

  const toggleNode = useCallback((nodeId: string) => {
    setOpenNodeMap((prev) => ({
      ...prev,
      [nodeId]: !prev[nodeId],
    }));
  }, []);

  return (
    <aside className="hidden w-72 border-r border-slate-200 bg-white dark:border-slate-700 dark:bg-slate-900 md:flex md:flex-col">
      <div className="border-b border-slate-200 px-4 py-4 dark:border-slate-700">
        <h2 className="text-lg font-semibold text-slate-900 dark:text-slate-100">Next Core</h2>
      </div>

      <div className="flex min-h-0 flex-1 flex-col px-3 py-4">
        <ul className="mb-4 space-y-1">
          <li>
            <Link
              href="/"
              className={`flex items-center gap-2 rounded-md px-3 py-2 text-sm ${
                pathname === "/"
                  ? "bg-slate-900 text-white dark:bg-slate-100 dark:text-slate-900"
                  : "text-slate-700 hover:bg-slate-100 dark:text-slate-200 dark:hover:bg-slate-800"
              }`}
            >
              <span className="pi pi-home text-sm" />
              Home
            </Link>
          </li>
        </ul>

        <nav className="min-h-0 flex-1 overflow-y-auto pr-1">
          <ul className="space-y-1">
            {visibleMainMenus.map((mainNode) => {
              const mainOpen = isOpen(mainNode);
              return (
                <li key={mainNode.objectId} className="space-y-1">
                  <button
                    type="button"
                    onClick={() => toggleNode(mainNode.objectId)}
                    className="flex w-full items-center justify-between rounded-md px-3 py-2 text-left text-sm font-medium text-slate-700 hover:bg-slate-100 dark:text-slate-200 dark:hover:bg-slate-800"
                  >
                    <span className="flex items-center gap-2">
                      <span className={mainNode.iconClass ?? "pi pi-folder"} />
                      {mainNode.moduleName ?? mainNode.title ?? mainNode.objectId}
                    </span>
                    <span className={`pi text-xs ${mainOpen ? "pi-chevron-down" : "pi-chevron-right"}`} />
                  </button>

                  {mainOpen ? (
                    <div className="space-y-1 pl-2">
                      {mainNode.childNodes.map((childNode) => {
                        if (childNode.subModuleName) {
                          if (!hasChildPermission(childNode, canView)) {
                            return null;
                          }

                          const childOpen = isOpen(childNode);
                          return (
                            <div key={childNode.objectId} className="space-y-1">
                              <button
                                type="button"
                                onClick={() => toggleNode(childNode.objectId)}
                                className="flex w-full items-center justify-between rounded-md px-3 py-2 text-left text-sm text-slate-700 hover:bg-slate-100 dark:text-slate-200 dark:hover:bg-slate-800"
                              >
                                <span className="flex items-center gap-2">
                                  <span className="pi pi-folder text-xs" />
                                  {childNode.subModuleName}
                                </span>
                                <span
                                  className={`pi text-xs ${
                                    childOpen ? "pi-chevron-down" : "pi-chevron-right"
                                  }`}
                                />
                              </button>

                              {childOpen ? (
                                <ul className="space-y-1 pl-2">
                                  {childNode.childNodes.map((subNode) => {
                                    if (!hasMainMenu(subNode)) {
                                      return null;
                                    }
                                    if (!hasScreenPermission(subNode.objectId, canView)) {
                                      return null;
                                    }

                                    const isActive = isPathActive(pathname, subNode.href);

                                    return (
                                      <li key={subNode.objectId}>
                                        <Link
                                          href={subNode.href ?? "#"}
                                          className={`flex items-center gap-2 rounded-md px-3 py-2 text-sm ${
                                            isActive
                                              ? "bg-slate-900 text-white dark:bg-slate-100 dark:text-slate-900"
                                              : "text-slate-600 hover:bg-slate-100 dark:text-slate-300 dark:hover:bg-slate-800"
                                          }`}
                                        >
                                          <span className="pi pi-file text-xs" />
                                          {subNode.title ?? subNode.objectId}
                                        </Link>
                                      </li>
                                    );
                                  })}
                                </ul>
                              ) : null}
                            </div>
                          );
                        }

                        if (!hasMainMenu(childNode)) {
                          return null;
                        }
                        if (!hasPermissionForNode(childNode, canView)) {
                          return null;
                        }

                        const isActive = isPathActive(pathname, childNode.href);

                        return (
                          <div key={childNode.objectId}>
                            <Link
                              href={childNode.href ?? "#"}
                              className={`flex items-center gap-2 rounded-md px-3 py-2 text-sm ${
                                isActive
                                  ? "bg-slate-900 text-white dark:bg-slate-100 dark:text-slate-900"
                                  : "text-slate-600 hover:bg-slate-100 dark:text-slate-300 dark:hover:bg-slate-800"
                              }`}
                            >
                              <span className={childNode.iconClass ?? "pi pi-file"} />
                              {childNode.title ?? childNode.objectId}
                            </Link>
                          </div>
                        );
                      })}
                    </div>
                  ) : null}
                </li>
              );
            })}
          </ul>
        </nav>

        <div className="mt-4 border-t border-slate-200 pt-4 dark:border-slate-700">
          {showExampleUI ? (
            <div className="mb-4 space-y-1">
              <p className="px-3 text-xs font-semibold uppercase tracking-wider text-amber-600 dark:text-amber-400">
                Dev Tools
              </p>
              <Link
                href="/example-ui"
                className={`flex items-center gap-2 rounded-md px-3 py-2 text-sm ${
                  isPathActive(pathname, "/example-ui")
                    ? "bg-amber-100 text-amber-800 dark:bg-amber-900/40 dark:text-amber-300"
                    : "text-slate-600 hover:bg-amber-50 dark:text-slate-300 dark:hover:bg-amber-900/20"
                }`}
              >
                <span className="pi pi-palette text-xs" />
                Button Sample
              </Link>
            </div>
          ) : null}
          <button
            type="button"
            onClick={() => signOut({ callbackUrl: "/login" })}
            className="flex w-full items-center gap-2 rounded-md px-3 py-2 text-sm text-rose-700 hover:bg-rose-50 dark:text-rose-400 dark:hover:bg-rose-900/30"
          >
            <span className="pi pi-sign-out" />
            Logout
          </button>
        </div>
      </div>
    </aside>
  );
}
