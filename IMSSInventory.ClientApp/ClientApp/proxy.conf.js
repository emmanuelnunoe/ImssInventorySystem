const { env } = require('process');

//const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
//  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:34592';

const PROXY_CONFIG = [
  {
    context: [
      "/api/*",
   ],
    target: "https://localhost:7070",
    secure: false,
    changeOrigin: true
  }
]

module.exports = PROXY_CONFIG;
