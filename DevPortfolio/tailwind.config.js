/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './**/*.{razor,html,cshtml}',
    './wwwroot/index.html',
    '!./bin/**',
    '!./obj/**',
    '!./node_modules/**',
  ],
  // These are composed at runtime (e.g. `text-cyber-@accent/80`) so Tailwind
  // can't see them in the markup — keep them from being purged.
  safelist: [
    'neon-text-cyan',
    'neon-text-magenta',
    'text-cyber-cyan/80',
    'text-cyber-magenta/80',
    'border-cyber-cyan/40',
    'border-cyber-magenta/40',
  ],
  theme: {
    extend: {
      colors: {
        cyber: {
          dark: '#030712',     // Deep space black
          bg: '#080711',       // Backdrop dark purple-tint
          cyan: '#00f0ff',     // Neon primary
          magenta: '#ff007f',  // Neon secondary
          purple: '#7000ff',   // Accent glow
        },
      },
      fontFamily: {
        mono: ['JetBrains Mono', 'Fira Code', 'ui-monospace', 'SFMono-Regular', 'monospace'],
      },
      boxShadow: {
        'glow-cyan': '0 0 15px rgba(0, 240, 255, 0.4), 0 0 30px rgba(0, 240, 255, 0.2)',
        'glow-magenta': '0 0 15px rgba(255, 0, 127, 0.4), 0 0 30px rgba(255, 0, 127, 0.2)',
        'glow-purple': '0 0 15px rgba(112, 0, 255, 0.4), 0 0 30px rgba(112, 0, 255, 0.2)',
        'glass-inner': 'inset 0 1px 1px 0 rgba(255, 255, 255, 0.05)',
      },
      backgroundImage: {
        'cyber-grid':
          'linear-gradient(to right, rgba(0,240,255,0.04) 1px, transparent 1px), linear-gradient(to bottom, rgba(0,240,255,0.04) 1px, transparent 1px)',
      },
      keyframes: {
        'pulse-glow': {
          '0%, 100%': { opacity: '0.4' },
          '50%': { opacity: '0.9' },
        },
        'float': {
          '0%, 100%': { transform: 'translateY(0px)' },
          '50%': { transform: 'translateY(-10px)' },
        },
        'flicker': {
          '0%, 19%, 21%, 23%, 25%, 54%, 56%, 100%': { opacity: '1' },
          '20%, 24%, 55%': { opacity: '0.4' },
        },
      },
      animation: {
        'pulse-glow': 'pulse-glow 4s ease-in-out infinite',
        'float': 'float 6s ease-in-out infinite',
        'flicker': 'flicker 3s linear infinite',
      },
    },
  },
  plugins: [],
};
