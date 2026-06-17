## Updated UI Specification: Modern Cyberpunk & Glassmorphism
To achieve a sleek, premium digital aesthetic, the design will rely on deep, translucent glass surfaces layered over vibrant, glowing neon accents.

+------------------------------------------------------------+

|  [Who Am I]         [Time Machine]          [Terminal]     |  <- Blurred Navigation Bar
+------------------------------------------------------------+

|                                                            |
|          _..---.._             / | \                       |
|       .'  ______  '.          /  |  \                      |
|      /   /      \   \        /   |   \                     |
|     |   |  USER  |   |       |   |   | [ Glass Card ]      |  <- 3D Flying Elements
|     |   |  IMAGE |   |       |=======|   Neon Cyan Border  |     (Simulation View)
|      \   \______/   /        |   |   |                     |
|       '.__________.'         \   |   /                     |
|                               \  |  /                      |
|                                  |                         |
|                                                            |
|  [ Neon Magenta Pulse ]      [ Neon Cyan Center Line ]     |  <- Background Glows
+------------------------------------------------------------+

------------------------------
## 🎨 Design System Variables (Tailwind CSS Configuration)
Add these custom utilities and extending classes to your tailwind.config.js to ensure consistent neon glow effects and glass textures across your Blazor pages:

module.exports = {
  theme: {
    extend: {
      colors: {
        cyber: {
          dark: '#030712',      // Deep space black
          bg: '#080711',        // Backdrop dark purple-tint
          cyan: '#00f0ff',      // Neon primary
          magenta: '#ff007f',   // Neon secondary
          purple: '#7000ff'     // Accent glow
        }
      },
      boxShadow: {
        'glow-cyan': '0 0 15px rgba(0, 240, 255, 0.4), 0 0 30px rgba(0, 240, 255, 0.2)',
        'glow-magenta': '0 0 15px rgba(255, 0, 127, 0.4), 0 0 30px rgba(255, 0, 127, 0.2)',
        'glass-inner': 'inset 0 1px 1px 0 rgba(255, 255, 255, 0.05)'
      },
      backgroundImage: {
        'cyber-grid': 'linear-gradient(to right, rgba(0,240,255,0.04) 1px, transparent 1px), linear-gradient(to bottom, rgba(0,240,255,0.04) 1px, transparent 1px)'
      }
    }
  }
}

------------------------------
## 💻 Component Styling Specifications## 1. The Global Backdrop (Background Grid & Glows)
The canvas should feel deep and alive.

* Base Class: bg-cyber-bg min-h-screen relative overflow-hidden bg-cyber-grid bg-[size:40px_40px] font-mono selection:bg-cyber-cyan selection:text-black
* Ambient Lighting: Place two large, blurred background radial gradients with low opacity to simulate deep neon smog:

<div class="absolute -top-40 -left-40 w-96 h-96 bg-cyber-purple/10 rounded-full blur-[120px] pointer-events-none"></div>
<div class="absolute bottom-10 right-10 w-[500px] h-[500px] bg-cyber-magenta/5 rounded-full blur-[150px] pointer-events-none"></div>


## 2. The Glassmorphic Wrapper Utility
Any card container (Profile, Experiences, Contact Terminal) should share a unified translucent layout:

* Tailwind Stack: bg-white/[0.02] backdrop-blur-md border border-white/10 rounded-2xl shadow-glass-inner
* Hover Enhancement: hover:border-cyber-cyan/40 transition-all duration-300 hover:shadow-glow-cyan

## 3. "The Simulation" Time Machine Core (Timeline.razor)

* Center Axis: A sharp, 1px glowing thread split down the viewport: w-[1px] bg-gradient-to-b from-cyber-cyan via-cyber-magenta to-cyber-purple shadow-glow-cyan.
* Alternating Elements:
* Left Cards: Bordered with a subtle cyan glow (border-cyber-cyan/20 hover:border-cyber-cyan).
   * Right Cards: Bordered with a subtle magenta glow (border-cyber-magenta/20 hover:border-cyber-magenta).
* 3D Transform States: When scrolling inside the GSAP loop, dynamically manipulate CSS attributes:
* transform: translate3d(x, y, z) rotateY(15deg); (Angled slightly inward toward the center line as they speed toward the user camera).

## 4. "Who Am I" Cyber Portrait

* Glass Photo Frame: Wrap your profile picture in a square glass element.
* Corner Decals: Use absolutely positioned tiny neon-cyan corner tick marks (+ signs or L borders) around the frame to give a high-tech HUD framing appearance.
* Backing Glow: Place a solid drop shadow behind the image layer utilizing shadow-glow-magenta.

------------------------------
## 🚀 Refined AI Builder Prompt
Give this updated instruction straight to your builder agent:

Act as an expert Blazor developer. Build a portfolio website using Blazor WASM targeting .NET 10, styled with Tailwind CSS.

Theme & Aesthetic:
- Modern Cyberpunk with High-Fidelity Glassmorphism.
- Primary colors: #030712 background, Neon Cyan (#00f0ff), and Neon Magenta (#ff007f).
- Background must use an ambient grid overlay with giant, highly-blurred colorful lighting blobs hidden behind components.
- Use glassmorphic classes across components: semi-transparent white fills (e.g., bg-white/5), heavy background blur (backdrop-blur-md), and crisp white borders with low opacity.

Component Mechanics:
1. `Layout`: Include a floating, glassmorphic header tracking navigation and a prominent neon button to toggle [EXIT SIMULATION].
2. `Timeline.razor`: In Simulation mode, arrange a center neon axis. Alternating left (cyan themed) and right (magenta themed) glass cards move dynamically down a 3D perspective path via GSAP as the user scrolls or drags. Active focused cards get an intense box-shadow glow. Clicking cards pops open an overlay modal utilizing matching glass styling.
3. `WhoAmI.razor` & `Contact.razor`: Present cleanly in "Flat Mode" or their respective views inside glowing corner HUD frames and sleek terminal boxes.

To optimize how the site handles high-resolution media, do you plan on hosting your images locally inside the GitHub repo asset folders, or will you be using an external image hosting service/CDN?

