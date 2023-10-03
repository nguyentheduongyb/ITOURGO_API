//APP DEVELOPMENT BY 
//PHONE DEVELOPMENT BY 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using B2B_API.Models;
using System.Text;
using System.Security.Cryptography;
using B2B_API.Providers.Entities;
using System.Web;

namespace B2B_API.Providers
{
    public class B2BOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly string _publicClientId;
        public B2BOAuthProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException("publicClientId");
            }
            _publicClientId = publicClientId;
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            string clientId = string.Empty;
            string clientSecret = string.Empty;
            Client client = null;

            var allowedOrigin = context.OwinContext.Get<string>("as:clientAllowedOrigin");
            if (allowedOrigin == null) allowedOrigin = "*";


            if (!context.TryGetBasicCredentials(out clientId, out clientSecret))
            {
                context.TryGetFormCredentials(out clientId, out clientSecret);
            }

            if (context.ClientId == null)
            {
                //Remove the comments from the below line context.SetError, and invalidate context 
                //if you want to force sending clientId/secrects once obtain access tokens. 
                context.Validated();
                context.SetError("invalid_clientId", "ClientId should be sent.");
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { allowedOrigin });
                return Task.FromResult<object>(null);
            }

            using (AuthRepository _repo = new AuthRepository())
            {
                client = _repo.FindClient(context.ClientId);
            }

            if (client == null)
            {
                context.SetError("invalid_clientId", string.Format("Client '{0}' is not registered in the system.", context.ClientId));
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { allowedOrigin });
                return Task.FromResult<object>(null);
            }

            if (client.ApplicationType == ApplicationTypes.NativeConfidential)
            {
                if (string.IsNullOrWhiteSpace(clientSecret))
                {
                    context.SetError("invalid_clientId", "Client secret should be sent.");
                    return Task.FromResult<object>(null);
                }
                else
                {
                    if (client.Secret != Helper.GetHash(clientSecret))
                    {
                        context.SetError("invalid_clientId", "Client secret is invalid.");
                        return Task.FromResult<object>(null);
                    }
                }
            }

            if (!client.Active)
            {
                context.SetError("invalid_clientId", "Client is inactive.");
                return Task.FromResult<object>(null);
            }

            context.OwinContext.Set<string>("as:clientAllowedOrigin", client.AllowedOrigin);

            context.OwinContext.Set<string>("as:clientRefreshTokenLifeTime", client.RefreshTokenLifeTime.ToString());

            context.Validated();
            return Task.FromResult<object>(null);


        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var tokendata = await context.Request.ReadFormAsync();
            

            TMSUser systemuser = null;

            var allowedOrigin = context.OwinContext.Get<string>("as:clientAllowedOrigin");
            if (allowedOrigin == null) allowedOrigin = "*";
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { allowedOrigin });
            
            bool IsLoginByCookie = false;

            if (!string.IsNullOrEmpty(tokendata["IsLoginByCookie"]))
                IsLoginByCookie = Convert.ToBoolean(tokendata["IsLoginByCookie"].ToString());
            
            var strPassword = "";
            if (!string.IsNullOrWhiteSpace(context.Password))
            {
                strPassword = App_Start.CMSService.Encrypt(context.Password);
                if (IsLoginByCookie)
                {
                    strPassword = context.Password;
                }
            }
            if (context.ClientId == null)
            {
                context.SetError("Access is denied", "Login mode not access!");
                return;
            }
            else if (context.ClientId == AuthenticationType.APPUser)
            {
                systemuser = B2B_API.Models.ApplicationDbContext.GetUserLogin(Convert.ToInt16(tokendata["intMemberTypeID"]), context.UserName, strPassword);
            }
            else if (context.ClientId == AuthenticationType.APPTHUser)
            {
                systemuser = B2B_API.Models.ApplicationDbContext.GetTHUserLogin(context.UserName, strPassword);
            }
            else if (context.ClientId == AuthenticationType.APPPngUser)
            {
                systemuser = B2B_API.Models.ApplicationDbContext.GetPngUserLogin(context.UserName, strPassword);
            }
            else if (context.ClientId == AuthenticationType.APPUserKey)
            {
                string strRemoteURL = "";
                if (HttpContext.Current.Request.UrlReferrer != null)
                {
                    strRemoteURL = HttpContext.Current.Request.UrlReferrer.Authority;
                }
                systemuser = B2B_API.Models.ApplicationDbContext.GetClientAuthenData(tokendata["appkey"], strRemoteURL);
            }
            else
            {
                context.SetError("Access is denied", "Login mode not access!");
                return;
            }


            if (systemuser.IsLogin == false)
            {
                context.SetError("Access is denied", systemuser.strMess);
                return;
            }




            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Name, systemuser.Id));
            identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
            identity.AddClaim(new Claim("ClientId", systemuser.ClientId));
            identity.AddClaim(new Claim("strUserGUID", systemuser.strUserGUID));
            identity.AddClaim(new Claim("strFullName", systemuser.strNameDisplay));
            identity.AddClaim(new Claim("strEmail", systemuser.Email));
            identity.AddClaim(new Claim("strHostAccess", (systemuser.strHostAccess == null) ? "" : systemuser.strHostAccess));

            AuthenticationProperties props;
            if (context.ClientId == AuthenticationType.APPUserKey)
            {
                props = new AuthenticationProperties(new Dictionary<string, string>
                {
                    { 
                        "as:client_id", (context.ClientId == null) ? string.Empty : context.ClientId
                    },
                    { 
                        "strCompanyGUID", systemuser.strUserGUID
                    },
                    { 
                        "strCompanyName", systemuser.strNameDisplay
                    },
                    {"strMemberAppKeyGUID",systemuser.strRemoteGUID }
                });
            }
            else
            {
                props = new AuthenticationProperties(new Dictionary<string, string>
                {
                    { 
                        "as:client_id", (context.ClientId == null) ? string.Empty : context.ClientId
                    },
                    { 
                        "strUserGUID", systemuser.strUserGUID
                    },
                    { 
                        "strFullName", systemuser.strNameDisplay
                    },
                     { 
                        "strEmail", systemuser.Email
                    }
                    ,
                     { 
                        "strAvata", systemuser.strAvata
                    }
                });
            }
            var ticket = new AuthenticationTicket(identity, props);
            context.Validated(ticket);
            context.Request.Context.Authentication.SignIn(identity);
        }

        //public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        //{
        //    var originalClient = context.Ticket.Properties.Dictionary["as:client_id"];
        //    var currentClient = context.ClientId;
        //    var allowedOrigin = context.OwinContext.Get<string>("as:clientAllowedOrigin");
        //    if (allowedOrigin == null) allowedOrigin = "*";
        //    context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { allowedOrigin });
        //    if (originalClient != currentClient)
        //    {
        //        context.SetError("invalid_clientId", "Refresh token is issued to a different clientId.");
        //        return Task.FromResult<object>(null);
        //    }

        //    // Change auth ticket for refresh token requests
        //    var newIdentity = new ClaimsIdentity(context.Ticket.Identity);

        //    var newClaim = newIdentity.Claims.Where(c => c.Type == "newClaim").FirstOrDefault();
        //    if (newClaim != null)
        //    {
        //        newIdentity.RemoveClaim(newClaim);
        //    }
        //    newIdentity.AddClaim(new Claim("newClaim", "newValue"));

        //    var newTicket = new AuthenticationTicket(newIdentity, context.Ticket.Properties);
        //    context.Validated(newTicket);

        //    return Task.FromResult<object>(null);
        //}

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }


    }
}