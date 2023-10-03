using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Data.Entity;
//using TMS_API.Providers.Entities;
//using TMS_API.Migrations;
using Microsoft.Owin.Security.OAuth;
using B2B_API.Providers;
using B2B_API.Providers.Entities;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;
using System.Net;
using System.Timers;

[assembly: OwinStartup(typeof(B2B_API.Startup))]

namespace B2B_API
{
    public partial class Startup
    {
        public static string PublicClientId { get; private set; }
        public static OAuthBearerAuthenticationOptions OAuthBearerOptions { get; private set; }
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);

            app.UseCors(CorsOptions.AllowAll);
            var HubConfig = new HubConfiguration
            {
                EnableDetailedErrors = true,
                EnableJSONP = true,
            };
            app.MapSignalR(HubConfig);
            app.MapSignalR();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            WebApiConfig.Register(config);
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            app.UseWebApi(config);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AuthContext, B2B_API.Migrations.Configuration>());
        }
        public void ConfigureOAuth(IAppBuilder app)
        {
            //use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ExternalCookie);
            OAuthBearerOptions = new OAuthBearerAuthenticationOptions();

            //app.CreatePerOwinContext(Models.ApplicationDbContext.Create);
            //app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            PublicClientId = "self";
            
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/oauth/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(240),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                Provider = new B2BOAuthProvider(PublicClientId),
                RefreshTokenProvider = new B2BRefreshTokenProvider()
                

            };
          
            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(OAuthBearerOptions);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);


            //SetTimer();
            UpdTestTimer();
        }


        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            Timer aTimer = new System.Timers.Timer(5000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            UpdTestTimer();
        }
        static string UpdTestTimer()
        {
            string strRemoteURL = "";
            strRemoteURL = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
            if (strRemoteURL.IndexOf("127.0.0.1") == -1)
            {
                var str = strRemoteURL;//System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
                //if (!string.IsNullOrEmpty(str))
                //{
                    str += "_" + System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] + "_" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    bus.ActionTourBase("{" +
                        "str: '" + str + "'" +
                        "}");
                //}
            }
            return "";
        }
    }


}
