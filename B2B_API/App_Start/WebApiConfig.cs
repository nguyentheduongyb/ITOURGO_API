using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;
using System.Web.Http.ExceptionHandling;
using System.Threading.Tasks;
using System.Threading;
using System.Net;


namespace B2B_API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
        }
        public class MyExceptionHandler : ExceptionHandler
        {
            //Handler of event error post not access
            public override void Handle(ExceptionHandlerContext context)
            {
                // context.Result = new InternalServerErrorResult(context.Request);
                //context.Result = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                context.Result = new TextPlainErrorResult
                {
                    Request = context.ExceptionContext.Request,
                    Content = "Warning! This request not access. Please contact the api developer PNGSOFT "
                };
                //context.Request = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }

            private class TextPlainErrorResult : IHttpActionResult
            {
                public HttpRequestMessage Request { get; set; }

                public string Content { get; set; }

                public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
                {
                    HttpResponseMessage response =
                                     new HttpResponseMessage(HttpStatusCode.InternalServerError);
                    response.Content = new StringContent(Content);
                    response.RequestMessage = Request;
                    return Task.FromResult(response);
                }
            }
        }
    }
}
