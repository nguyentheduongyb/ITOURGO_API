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
using System.Threading;
using System.Security.Principal;
using System.Net;

namespace B2B_API.Filter
{
    //APP DEVELOPMENT BY 
    
    public class TMSAuthorizationFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext context)
        {

            if (context.Request.Headers.Authorization != null)
            {
                var authToken = context.Request.Headers
                    .Authorization.Parameter;

                // decoding authToken we get decode value in 'Username:Password' format  
                var decodeauthToken = authToken;//System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(authToken));

                // spliting decodeauthToken using ':'   
                var arrUserNameandPassword = decodeauthToken.Split(':');

                // at 0th postion of array we get username and at 1st we get password  
                if (GetCheckLoginFromTMS(arrUserNameandPassword[0], arrUserNameandPassword[1]))
                {
                    // setting current principle  
                    Thread.CurrentPrincipal = new GenericPrincipal(
                           new GenericIdentity(arrUserNameandPassword[0]), null);
                }
                else
                {
                    context.Response = context.Request
                        .CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
            else
            {
                context.Response = context.Request
                    .CreateResponse(HttpStatusCode.Unauthorized);
            }


            //var identity = (System.Security.Claims.ClaimsPrincipal)System.Threading.Thread.CurrentPrincipal;
            //var claims = identity.Claims;
            //string strClientId = ((System.Security.Claims.ClaimsIdentity)System.Web.HttpContext.Current.User.Identity).FindFirst("ClientId").Value;
            //string strHostAccess = ((System.Security.Claims.ClaimsIdentity)System.Web.HttpContext.Current.User.Identity).FindFirst("strHostAccess").Value;
            //if (strClientId == AuthenticationType.APPUserKey)
            //{
            //    if (strHostAccess == "")
            //    {
            //        context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Forbidden, "Host remote unlicensed access to the server.");
            //    }
            //    else
            //    {
            //        string strHostAddress = HttpContext.Current.Request.UrlReferrer.Authority;
            //        if (strHostAccess.IndexOf(strHostAddress) == -1)
            //        {
            //            context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Forbidden, "Host remote unlicensed access to the server.");
            //        }
            //    }
            //}
            //else
            //{
            //    context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Forbidden, "Warning! you are not allowed to access this api!");
            //}
        }


        public static bool GetCheckLoginFromTMS(string Username, string Password)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();

            var strJson = "{";
                strJson += "strCompanyGUID:'" + Username + "'";
                strJson += ",strKeyAccessToken:'" + Password + "'";
            strJson += "}";

            System.Data.DataTable dt = bus.ActionMember(strJson).Tables[0];

            return dt.Rows[0]["intRtn"].ToString() == "1";
        }

    }
}