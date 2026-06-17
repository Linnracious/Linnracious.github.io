// Single Page Apps for GitHub Pages
// https://github.com/rafrex/spa-github-pages
// 404.html stashes the requested deep link into the query string; this restores
// it to a clean URL before Blazor's router boots, so refreshes / deep links work.
(function (l) {
  if (l.search[1] === '/') {
    var decoded = l.search
      .slice(1)
      .split('&')
      .map(function (s) {
        return s.replace(/~and~/g, '&');
      })
      .join('?');
    window.history.replaceState(null, null, l.pathname.slice(0, -1) + decoded + l.hash);
  }
})(window.location);
