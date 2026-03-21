# Next Core

Next Core คือโปรเจกต์ตั้งต้นสำหรับระบบภายในองค์กรที่พัฒนาด้วย Next.js 16, React 19 และ TypeScript โดยรวมงานที่มักต้องใช้ในระบบจริงไว้แล้ว เช่น authentication, OTP flow, permission-based UI, dynamic i18n resources, PrimeReact UI และ Docker สำหรับรันแอปผ่าน Nginx

## จุดเด่นของโปรเจกต์

- ใช้ App Router ของ Next.js 16 พร้อมโครงสร้างแยก `auth`, `main`, `api` ชัดเจน
- เชื่อม NextAuth v5 กับ backend ภายนอกผ่าน credential login และ refresh token
- รองรับ flow login, register, first login, send OTP, resend OTP และ verify OTP
- มีระบบตรวจสิทธิ์จาก `permissionScreen` และ `PermissionGate` สำหรับซ่อน/แสดง UI ตามสิทธิ์
- ดึง localized resources, messages และ screen metadata จาก backend แล้ว cache ใน `localStorage`
- ใช้งาน PrimeReact + Tailwind CSS v4 + PrimeIcons สำหรับ UI
- มี theme provider, loading store และ utility hooks พร้อมใช้งาน
- รองรับการรันแบบ local และผ่าน Docker Compose

## Tech Stack

- Next.js 16
- React 19
- TypeScript
- NextAuth v5 beta
- PrimeReact / PrimeIcons
- Tailwind CSS v4
- React Hook Form + Zod
- i18next + react-i18next
- Axios
- Zustand

## โครงสร้างหลัก

```text
src/
|- app/
|  |- (auth)/              หน้า login / register / first login / confirm OTP
|  |- (main)/              หน้าที่ต้อง login ก่อนเข้าใช้งาน
|  |- [locale]/            locale wrapper + global loading
|  \- api/                 route handlers สำหรับ auth, OTP, resources, translations
|- auth.ts                 การตั้งค่า NextAuth และ token refresh
|- components/
|  |- common/              component ใช้ซ้ำ เช่น navbar, sidebar, loading, permission gate
|  |- features/            component แยกตาม business feature
|  \- ui/                  ปุ่ม, input, table และ UI พื้นฐาน
|- hooks/                  custom hooks
|- lib/                    i18n, axios, auth token, permissions และ helper กลาง
|- providers/              provider ของ theme, session และ PrimeReact
|- services/               service layer ฝั่ง client/server
|- store/                  Zustand stores
\- types/                  type definitions
```

## หน้าหลักที่มีในระบบ

Public routes:

- `/login`
- `/register`
- `/firstlogin`
- `/confirm-otp`

Protected routes:

- `/dashboard`
- `/users`
- `/users/[id]`

API routes สำคัญ:

- `/api/auth/[...nextauth]`
- `/api/auth/prelogin`
- `/api/auth/firstlogin`
- `/api/auth/otp/send`
- `/api/auth/otp/resend`
- `/api/auth/otp/verify`
- `/api/auth/resources/localized`
- `/api/resources/localized`
- `/api/translations`

หมายเหตุ: root ของแอปถูกวางให้อยู่ใน flow ที่ต้องมี session หากไม่มี access token จะถูก redirect ไปที่ `/login`

## เริ่มต้นใช้งาน

### 1. สิ่งที่ต้องมี

- Node.js 20 ขึ้นไป
- npm

### 2. ติดตั้ง dependencies

```bash
npm install
```

### 3. ตั้งค่า environment

คัดลอกไฟล์ตัวอย่างแล้วแก้ค่าให้ตรงกับ backend ของคุณ

```bash
cp .env.example .env.local
```

สำหรับ PowerShell:

```powershell
Copy-Item .env.example .env.local
```

### 4. รันในโหมดพัฒนา

```bash
npm run dev
```

เปิดใช้งานที่ [http://localhost:3000](http://localhost:3000)

## Environment Variables

ค่าที่ควรตั้งอย่างน้อยก่อนรันระบบ:

- `NEXT_PUBLIC_API_URL`
- `AUTH_API_URL`
- `AUTH_SECRET`
- `AUTH_LOGIN_PATH`
- `AUTH_REFRESH_PATH`

ตัวแปรทั้งหมดใน `.env.example`

| Variable | ใช้สำหรับ |
| --- | --- |
| `NEXT_PUBLIC_API_URL` | Base URL ของ backend หลัก |
| `NEXT_PUBLIC_APP_NAME` | ชื่อแอปที่ใช้แสดงผลใน UI |
| `NEXT_PUBLIC_COOKIE_ACCESS` | ชื่อ cookie สำหรับ access token ถ้ามีการใช้งานร่วมกับ backend |
| `NEXT_PUBLIC_COOKIE_REFRESH` | ชื่อ cookie สำหรับ refresh token ถ้ามีการใช้งานร่วมกับ backend |
| `NEXT_PUBLIC_UMS_GET_BY_ID_PATH` | path สำหรับดึงข้อมูล user ตาม id |
| `NEXT_PUBLIC_UMS_CHANGE_PASSWORD_PATH` | path สำหรับเปลี่ยนรหัสผ่าน |
| `NEXT_PUBLIC_LOCALIZED_RESOURCES_TTL_MINUTES` | อายุ cache ของ localized resources ใน browser |
| `NEXT_PUBLIC_LOCALIZED_RESOURCES_API_PATH` | path สำหรับโหลด localized resources |
| `NEXT_PUBLIC_I18N_DEBUG` | เปิด log debug ของ i18n |
| `AUTH_SECRET` | secret ของ NextAuth |
| `AUTH_API_URL` | Base URL ของ auth/backend service |
| `AUTH_LOGIN_PATH` | path สำหรับ login |
| `AUTH_REFRESH_PATH` | path สำหรับ refresh token |
| `AUTH_FIRST_LOGIN_PATH` | path สำหรับ first login |
| `AUTH_OTP_SEND_PATH` | path สำหรับส่ง OTP |
| `AUTH_OTP_VERIFY_PATH` | path สำหรับยืนยัน OTP |
| `AUTH_OTP_RESEND_PATH` | path สำหรับส่ง OTP ใหม่ |
| `AUTH_RESOURCES_PATH` | path สำหรับโหลด resource หลักจาก backend |
| `AUTH_SYSTEM_RESOURCES_PATH` | path สำหรับ system resources |
| `AUTH_SYSTEM_MESSAGES_PATH` | path สำหรับ system messages |
| `AUTH_SYSTEM_SITEMAPS_PATH` | path สำหรับ system sitemap/menu |
| `JWT_KEY` | key สำหรับงานที่เกี่ยวกับ JWT ฝั่ง backend integration |
| `JWT_ISSUER` | issuer ของ JWT |
| `JWT_EXPIRE_MINUTES` | อายุ token ที่คาดหวัง |
| `AUTH_TRUST_HOST` | ค่า trust host สำหรับ NextAuth |

## คำสั่งที่ใช้บ่อย

```bash
npm run dev
npm run build
npm run start
npm run lint
```

## Docker

โปรเจกต์มี Dockerfile และ Compose แยก dev/prod ไว้แล้ว

Development:

```bash
docker compose up --build
```

- App จะรันที่ `http://localhost:3000`
- Nginx จะเปิดที่ `http://localhost:8080`

Production:

```bash
docker compose -f docker-compose.prod.yml up --build -d
```

- Nginx จะเปิดที่ port `80`

หมายเหตุ:

- `docker-compose.yml` อ้างอิงไฟล์ `./docker/env/.env.development`
- `docker-compose.prod.yml` อ้างอิงไฟล์ `./docker/env/.env.production`
- ใน repo ปัจจุบันยังไม่มีไฟล์ env ทั้งสองตัว ต้องสร้างเพิ่มเองก่อนใช้งาน Docker

## พฤติกรรมสำคัญของระบบ

- Session ใช้ `jwt` strategy และจะพยายาม refresh token อัตโนมัติเมื่อ access token หมดอายุ
- Language รองรับ `th` และ `en` โดย normalize ค่าจาก backend เช่น `lc` ให้เป็น `th`
- Localized resources จะถูกโหลดหลัง session พร้อม cache ตาม `customerId`
- Permission ถูก parse จาก `permissionScreen` และรองรับ function code แบบ `View`, `New`, `Edit`, `Delete`, `Export`, `Print`

## หมายเหตุสำหรับผู้พัฒนาต่อ

- หน้า `dashboard` และ `users` ในตอนนี้เป็นโครงสร้างตั้งต้นและมีข้อมูลตัวอย่างบางส่วน
- ถ้าจะเชื่อม backend เพิ่ม ให้ดูที่ `src/auth.ts`, `src/lib/`, `src/services/` และ `src/app/api/`
- ถ้าจะปรับเมนู ให้เริ่มจาก `src/lib/siteMap.ts`
