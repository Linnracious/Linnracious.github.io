// ---------------------------------------------------------------------------
// "The Simulation" — Z-axis wormhole engine (vanilla CSS 3D, no libraries).
//
// The scroll wheel does NOT scroll the page; it drives translateZ on the World
// container, flying the camera down the tunnel. Orbs sit at fixed Z depths and
// grow/fade via CSS perspective as the camera approaches and passes them.
//
// Exposed to Blazor via window.simulation.*  (called through IJSRuntime).
// ---------------------------------------------------------------------------
window.simulation = (function () {
  // --- Tunable feel ---------------------------------------------------------
  const SPEED = 1.25;      // depth pixels per wheel-delta pixel
  const TOUCH_SPEED = 2.2; // depth pixels per touch-drag pixel
  const KEY_STEP = 220;    // depth pixels per arrow-key press
  const END_MARGIN = 150;  // how close the final orb settles to the camera
  // -------------------------------------------------------------------------

  let vp = null, world = null;
  let orbs = [];
  let hudYear = null, hudTitle = null;
  let depth = 0, maxDepth = 0, paused = false;
  let activeYear = null;
  let touchY = 0;
  let mouseHandler = null;

  // ---- Wormhole lifecycle --------------------------------------------------
  function initWorld() {
    disposeWorld();

    vp = document.querySelector('.wh-viewport');
    world = document.querySelector('.wh-world');
    if (!vp || !world) return;

    orbs = Array.prototype.slice.call(world.querySelectorAll('.wh-orb'));
    hudYear = document.querySelector('.wh-hud-year');
    hudTitle = document.querySelector('.wh-hud-title');
    depth = 0;
    paused = false;

    const maxAbs = orbs.reduce((m, o) => Math.max(m, -parseFloat(o.dataset.z || '0')), 0);
    maxDepth = Math.max(0, maxAbs - END_MARGIN);

    vp.addEventListener('wheel', onWheel, { passive: false });
    vp.addEventListener('touchstart', onTouchStart, { passive: false });
    vp.addEventListener('touchmove', onTouchMove, { passive: false });
    window.addEventListener('keydown', onKey);

    // Lock the page behind the overlay.
    document.body.style.overflow = 'hidden';

    render();
  }

  function disposeWorld() {
    if (vp) {
      vp.removeEventListener('wheel', onWheel);
      vp.removeEventListener('touchstart', onTouchStart);
      vp.removeEventListener('touchmove', onTouchMove);
    }
    window.removeEventListener('keydown', onKey);
    document.body.style.overflow = '';
    vp = null;
    world = null;
    orbs = [];
  }

  // Blazor pauses the engine while a modal is open.
  function setPaused(p) {
    paused = !!p;
  }

  // Which orb is currently centered (read by Blazor on click).
  function getActiveYear() {
    return activeYear;
  }

  // The scrollable back face of the currently-open card (if any).
  function openCard() {
    return document.querySelector('.wh-orb--open .wh-face-back .wh-card');
  }

  // ---- Input ---------------------------------------------------------------
  function onWheel(e) {
    // While a card is open, scroll IT — not the tunnel. We do this by hand
    // because native scroll-chaining is unreliable through the 3D-rotated face.
    if (paused) {
      const card = openCard();
      if (card) {
        e.preventDefault();
        card.scrollTop += e.deltaY;
      }
      return;
    }
    e.preventDefault();
    setDepth(depth + e.deltaY * SPEED);
  }
  function onTouchStart(e) {
    touchY = e.touches[0].clientY;
  }
  function onTouchMove(e) {
    const y = e.touches[0].clientY;
    if (paused) {
      const card = openCard();
      if (card) {
        e.preventDefault();
        card.scrollTop += touchY - y;
      }
      touchY = y;
      return;
    }
    e.preventDefault();
    setDepth(depth + (touchY - y) * TOUCH_SPEED);
    touchY = y;
  }
  function onKey(e) {
    if (paused || !vp) return;
    if (e.key === 'ArrowDown' || e.key === 'PageDown') { e.preventDefault(); setDepth(depth + KEY_STEP); }
    if (e.key === 'ArrowUp' || e.key === 'PageUp') { e.preventDefault(); setDepth(depth - KEY_STEP); }
  }

  function setDepth(d) {
    depth = Math.max(0, Math.min(d, maxDepth));
    render();
  }

  // ---- Frame ---------------------------------------------------------------
  function render() {
    if (!world) return;
    world.style.transform = `translateZ(${depth}px)`;
    if (vp) vp.style.setProperty('--progress', (maxDepth ? depth / maxDepth : 0).toFixed(4));

    let active = null;
    let activeDist = Infinity;

    orbs.forEach((orb) => {
      // A flipped-open card is frozen at full opacity and stays interactive.
      if (orb.classList.contains('wh-orb--open')) {
        orb.style.opacity = '1';
        orb.style.pointerEvents = 'auto';
        return;
      }

      const z = parseFloat(orb.dataset.z) + depth; // depth in camera space

      // Fade in from the deep dark, blow out as it flies past the camera.
      let op = 1;
      if (z > -140) op = Math.max(0, 1 - (z + 140) / 200);          // passing the camera
      else if (z < -1500) op = Math.max(0, 1 - (-z - 1500) / 1000); // receding into the dark
      orb.style.opacity = op.toFixed(3);

      // Clickable whenever it's reasonably visible — whatever you can see, you
      // can click (the frontmost visible orb wins the hit-test).
      orb.style.pointerEvents = op > 0.4 ? 'auto' : 'none';
      orb.classList.toggle('wh-orb--active', op > 0.6 && z > -900 && z < 80);

      const dist = Math.abs(z + 250); // prefer the orb sitting just in front
      if (op > 0.4 && dist < activeDist) {
        activeDist = dist;
        active = orb;
      }
    });

    if (active) {
      activeYear = active.dataset.year || null;
      if (hudYear) hudYear.textContent = active.dataset.year || '';
      if (hudTitle) hudTitle.textContent = active.dataset.title || '';
    }
  }

  // ---- Hero portrait tilt (used outside the wormhole) ----------------------
  function initPortraitTilt(el) {
    if (!el) return;
    mouseHandler = (e) => {
      const r = el.getBoundingClientRect();
      const px = (e.clientX - r.left) / r.width - 0.5;
      const py = (e.clientY - r.top) / r.height - 0.5;
      el.style.transform = `perspective(800px) rotateY(${px * 12}deg) rotateX(${-py * 12}deg)`;
    };
    const reset = () => (el.style.transform = 'perspective(800px) rotateY(0) rotateX(0)');
    el.addEventListener('mousemove', mouseHandler);
    el.addEventListener('mouseleave', reset);
  }

  function scrollToId(id) {
    const el = document.getElementById(id);
    if (el) el.scrollIntoView({ behavior: 'smooth', block: 'start' });
  }

  return { initWorld, disposeWorld, setPaused, getActiveYear, initPortraitTilt, scrollToId };
})();
