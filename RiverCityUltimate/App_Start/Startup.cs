using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Twitter;
using Owin;
using RiverCityUltimate.Core;

[assembly: OwinStartup(typeof(RiverCityUltimate.Startup))]

namespace RiverCityUltimate
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseTwitterAuthentication(Settings.TwitterConfig.ApiKey, Settings.TwitterConfig.ApiSecret);
            app.UseGoogleAuthentication(Settings.GoogleConfig.OAuthClientId, Settings.GoogleConfig.OAuthClientSecret);
        }
    }
}
