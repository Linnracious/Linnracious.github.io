# NEXUS — Cyberpunk Dev Portfolio

A single-page developer portfolio built with **Blazor WebAssembly (.NET 10)** and **Tailwind CSS**, styled with a modern cyberpunk + glassmorphism aesthetic. Designed to deploy to **GitHub Pages**.

## Features

- **Glassmorphic UI** — translucent glass surfaces, neon cyan/magenta accents, ambient grid + blurred light blobs.
- **The Time Machine** — a calm vertical timeline by default; hit **ENTER SIMULATION** for a full-viewport **Z-axis wormhole** where the wheel flies the camera down a tunnel and record cards rush past (pure CSS 3D, no libraries).
- **ENTER / EXIT SIMULATION** — toggles the immersive wormhole takeover on and off.
- **Cyber portrait** — HUD-framed profile photo with corner decals and cursor-tracking tilt.
- **Contact terminal** — a faux terminal listing your channels.
- Reduced-motion friendly, responsive, keyboard-reachable nav.

## Project layout

```
devportfolio/
├─ .github/workflows/deploy.yml   # CI: build + deploy to GitHub Pages
└─ DevPortfolio/                  # the Blazor WASM app
   ├─ Components/                 # WhoAmI, Timeline, Contact, CyberBackdrop
   ├─ Layout/MainLayout.razor     # floating glass header + EXIT SIMULATION
   ├─ Models/ , Services/         # data + simulation state
   ├─ Styles/app.css              # Tailwind source (compiled to wwwroot/css/app.css)
   ├─ wwwroot/                    # index.html, 404.html, .nojekyll, js/, assets/
   ├─ tailwind.config.js
   └─ DevPortfolio.csproj         # runs Tailwind automatically on build
```

## Run locally

```bash
cd DevPortfolio
dotnet run
```

The `.csproj` compiles Tailwind automatically before each build. For a live-reloading
stylesheet while editing classes, run this in a second terminal:

```bash
npm run watch:css
```

> **Base path:** `index.html` ships with `<base href="/">` so local `dotnet run`
> works at the root URL the CLI prints. The deploy workflow rewrites it to
> `/<repo>/` for the GitHub Pages project page — you don't edit it by hand.

## Editing content

All placeholder content lives in:

- `Services/PortfolioData.cs` — timeline entries
- `Models/Profile.cs` — name, role, bio, tech stack, social links
- `wwwroot/assets/profile.svg` — replace with your real photo (e.g. `profile.jpg`),
  then update `PhotoUrl` in `Models/Profile.cs`.

## Deploy to GitHub Pages

1. Create a repo named **`devportfolio`** and push this code to `main`.
2. In **Settings → Pages**, set **Source = GitHub Actions**.
3. Push — the workflow builds and publishes automatically. Your site appears at
   `https://<username>.github.io/devportfolio/`.

### Different repo name

Nothing to do — the workflow derives the base path from the repo name automatically
and `pathSegmentsToKeep = 1` in `404.html` works for any project page.

### User/org page or custom domain

These serve from the root, so the base path must stay `/`:

- Delete (or skip) the **"Set base href for GitHub Pages"** step in `deploy.yml`.
- Set `pathSegmentsToKeep = 0` in `wwwroot/404.html`.
- For a custom domain, add a `CNAME` file to `wwwroot/`.
