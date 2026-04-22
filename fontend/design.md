# Frontend Design

This document reflects the current implementation in this repo, not planned behavior.

## Overview

This frontend is an internal web app starter built with Next.js 16, React 19, and TypeScript. The strongest implemented areas are:

- authentication and session handling
- OTP and first-login flows
- permission-driven navigation and actions
- backend-driven i18n resource loading
- protected app shell with theme switching

Most business screens are still starter/demo-level. The most complete business-facing screen today is the user info page.

## Stack

- Next.js 16 App Router
- React 19
- TypeScript
- NextAuth v5 with JWT sessions
- PrimeReact + PrimeIcons
- Tailwind CSS v4
- i18next + react-i18next
- Zustand
- axios

## App Structure

```text
src/app/(auth)      public auth routes
src/app/(main)      protected routes
src/app/[locale]    locale wrapper + GlobalLoading
src/app/api         BFF/proxy route handlers
src/components/ui   low-level UI wrappers
src/components/common shared app components
src/components/features feature modules
src/lib             auth, permissions, i18n, HTTP helpers
src/services        backend access
src/store           zustand stores
```

## Routes

Public routes:

- `/login`
- `/register`
- `/firstlogin`
- `/confirm-otp`

Protected routes:

- `/`
- `/dashboard`
- `/users`
- `/users/[id]`

Dev-only routes when `NEXT_PUBLIC_SHOW_EXAMPLE_UI=true`:

- `/example-ui`
- `/example-ui/pdf-signature`
- `/example-ui/pdf-annotate`

Main API routes:

- `/api/auth/[...nextauth]`
- `/api/auth/prelogin`
- `/api/auth/firstlogin`
- `/api/auth/otp/send`
- `/api/auth/otp/resend`
- `/api/auth/otp/verify`
- `/api/auth/resources/localized`
- `/api/resources/localized`
- `/api/translations`

## Layout Design

### Root

`RootLayout` wraps the app with:

```text
ThemeProvider
-> SessionProvider
-> PrimeReactAppProvider
-> LocalizedResourcesBootstrap
```

This makes theme, session, PrimeReact config, and i18n bootstrap globally available.

### Auth Shell

The login page is the most polished screen in the repo:

- split-screen on desktop
- illustration on the left
- dark gradient panel on the right
- responsive collapse to one column on mobile

Other auth screens (`register`, `firstlogin`, `confirm-otp`) use much simpler centered forms, so the auth area is visually inconsistent today.

### Main Shell

Protected routes use a classic internal-app shell:

- left sidebar
- top navbar
- padded main content area

`Footer` exists but is currently disabled in the main layout.

## Navigation

### Sidebar

The sidebar is built from `siteMapNodes` and filtered by user permissions.

Current behavior:

- menus without permission are hidden
- nested menu groups are supported
- a dev tools section appears only behind an env flag
- logout is placed at the bottom

Important limitation:

- the sidebar is hidden below `md`
- there is no mobile drawer replacement yet

### Navbar

The navbar is intentionally light. It currently provides:

- app title
- link to user info
- theme toggle
- language switcher

It does not yet act as a global command area for search, notifications, or breadcrumbs.

## Auth and Session Flow

The login flow is not a single direct sign-in. It first runs a pre-login decision step.

```text
LoginForm
-> POST /api/auth/prelogin
-> backend login endpoint

Possible outcomes:
- direct login payload
- verify_login_required
- first_login_required
```

### Direct Login

If the backend returns a usable login payload, the UI calls:

```text
signIn("credentials", { mode: "direct" })
```

### OTP Login

If OTP is required:

```text
/login
-> /api/auth/prelogin
-> /confirm-otp
-> /api/auth/otp/verify
-> signIn("credentials", mode="direct")
```

### First Login

If password change is required on first login:

```text
/login
-> /api/auth/prelogin
-> /firstlogin
-> /api/auth/firstlogin
-> signIn("credentials", mode="direct")
```

### Session Model

NextAuth stores the main auth state in the JWT/session, including:

- `accessToken`
- `refreshToken`
- `customerId`
- `permissionScreen`
- `languageCode`
- `userNumber`

The JWT callback refreshes the access token when expired. It can also refresh when the user changes language.

## Permission Model

Permissions come from `session.permissionScreen`.

The permission string is parsed into a permission map and supports:

- raw JSON
- base64-encoded JSON

Used by:

- `useHasPermission`
- `Sidebar`
- `PermissionGate`
- `CommandButton`

Supported function codes:

- `View`
- `New`
- `Edit`
- `Delete`
- `Export`
- `Print`

Permission behavior in UI is deliberate:

- some items are hidden when access is denied
- some actions can be shown but disabled

The app also includes dedicated forbidden UI via `ForbiddenScreen` and `/forbidden`.

## i18n and Resource Loading

Localization is backend-driven rather than file-only.

Flow:

```text
Session available
-> LocalizedResourcesBootstrap
-> initI18n(languageCode, customerId)
-> /api/auth/resources/localized
-> resourceService.server
-> backend resources/messages/sitemaps
-> i18next bundles
```

Client-side resource bundles are cached in `localStorage` by `customerId`, with TTL controlled by env.

The language switcher:

- initializes i18n for the target language
- updates the session
- refreshes the page
- signs the user out if token refresh fails

## Component Architecture

### `ui`

Reusable low-level wrappers and primitives:

- `Button`
- `InputField`
- `PasswordField`
- `DataTable`
- `Modal`
- `SignaturePad`
- `CommandButton`

### `common`

Shared app-level components:

- `Navbar`
- `Sidebar`
- `ThemeToggle`
- `LanguageSwitcher`
- `PermissionGate`
- `ForbiddenScreen`
- `GlobalLoading`

### `features`

Feature-specific modules:

- `features/auth/*`
- `features/users/*`

This separation is good enough for a starter and should scale if kept consistent.

## Data Access Pattern

The repo currently mixes several access styles:

- `fetch` in auth flows and route handlers
- `axios` via shared HTTP helpers
- service-layer functions in `src/services`

This works, but it increases inconsistency. A future cleanup should define when to use:

- direct client fetch
- route handler/BFF
- shared service wrapper

## Current Screen Status

| Route | Status | Notes |
| --- | --- | --- |
| `/login` | strong | polished UI and real auth branching |
| `/register` | scaffold | simple form only |
| `/firstlogin` | functional | works, but simple UI |
| `/confirm-otp` | functional | works, but simple UI |
| `/dashboard` | placeholder | starter content |
| `/users` | demo | static sample data |
| `/users/[id]` | integrated | real fetch and password change flow |
| `/example-ui/*` | dev-only | playground and PDF demos |

## Strengths

- Real auth complexity is already implemented.
- Permission-aware navigation and actions are in place.
- i18n is integrated with backend resources and caching.
- Public and protected route concerns are clearly separated.
- The login page already establishes a better visual direction than a typical starter.

## Gaps

- Auth pages are not visually consistent.
- Mobile navigation is incomplete because the sidebar disappears without replacement.
- Business pages are still mostly starter/demo screens.
- State ownership is not fully clean because NextAuth and local stores coexist.
- Data access conventions are mixed.
- `[locale]` and `GlobalLoading` exist, but they are not central to all primary routes yet.

## Recommended Next Steps

1. Add a mobile navigation pattern for protected routes.
2. Unify the visual design of all auth pages around the login page quality.
3. Move `dashboard` and `users` from starter/demo state to real business flows.
4. Standardize the API access pattern across `fetch`, route handlers, and services.
5. Formalize a small design token layer for colors, spacing, surfaces, and states.

## Summary

This frontend is best understood as a strong platform starter for internal systems. Its foundations are already solid in auth, permissions, localization, and app shell structure. Its weakest area is not the platform layer, but the unfinished business screens and uneven UX consistency across routes.
