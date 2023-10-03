using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Microsoft.AspNet.Identity.Owin;
using B2B_API.Providers.Entities;
namespace B2B_API.Filter
{
    //APP DEVELOPMENT BY 
    
    public class CMSCompanyFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext context)
        {
            var identity = (System.Security.Claims.ClaimsPrincipal)System.Threading.Thread.CurrentPrincipal;
            var claims = identity.Claims;
            string strClientId = ((System.Security.Claims.ClaimsIdentity)System.Web.HttpContext.Current.User.Identity).FindFirst("ClientId").Value;
            string strHostAccess = ((System.Security.Claims.ClaimsIdentity)System.Web.HttpContext.Current.User.Identity).FindFirst("strHostAccess").Value;
            if (strClientId == AuthenticationType.APPUserKey)
            {
                if (strHostAccess == "")
                {
                    context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Forbidden, "Host remote unlicensed access to the server.");
                }
                else
                {
                    string strHostAddress = HttpContext.Current.Request.UrlReferrer.Authority;
                    if (strHostAccess.IndexOf(strHostAddress) == -1)
                    {
                        context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Forbidden, "Host remote unlicensed access to the server.");
                    }
                }
            }
            else
            {
                context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Forbidden, "Warning! you are not allowed to access this api!");
            }
        }
    }
}