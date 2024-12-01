using Microsoft.Owin.Cors;

using Owin;

using Swashbuckle.Application;
using System;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http;

[assembly: Microsoft.Owin.OwinStartup(typeof(WebApi.Startup))]
namespace WebApi
{
    /// <summary>
    /// Startup class for the OWIN middleware.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Startup Configuration
        /// </summary>
        /// <param name="appBuilder"></param>
        public void Configuration(IAppBuilder appBuilder)
        {
//#if !DEBUG
//                // Enforce HTTPS
//                appBuilder.Use(async (context, next) =>
//                {
//                    if (context.Request.Scheme != Uri.UriSchemeHttps)
//                    {
//                        var withHttps = "https://" + context.Request.Host + context.Request.Path + context.Request.QueryString;
//                        context.Response.Redirect(withHttps);
//                    }
//                    else
//                    {
//                        await next();
//                    }
//                });
//#endif
            // Add security headers
            appBuilder.Use(async (context, next) =>
            {
                // Check if the request is for Swagger UI
                if (context.Request.Path.Value.Contains("/swagger"))
                {
                    // Adjust CSP to allow inline scripts for Swagger UI
                    context.Response.Headers.Add("Content-Security-Policy", new[] { "default-src 'self'; script-src 'self' 'unsafe-inline'; style-src 'self' 'unsafe-inline'" });
                }
                else
                {
                    // Default CSP for other requests
                    context.Response.Headers.Add("Content-Security-Policy", new[] { "default-src 'self'" });
                }

                context.Response.Headers.Add("X-Content-Type-Options", new[] { "nosniff" });
                context.Response.Headers.Add("X-Frame-Options", new[] { "DENY" });
                await next();
            });

            //            // Secutiry configuration.
            //            var oAuthServerOptions = new OAuthAuthorizationServerOptions
            //            {
            //#if DEBUG
            //                AllowInsecureHttp = true,
            //#else
            //                AllowInsecureHttp = false, // Ensure this is false in production
            //#endif
            //                TokenEndpointPath = new PathString("/token"),
            //                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
            //                Provider = new SimpleAuthorizationServerProvider()
            //            };

            //appBuilder.UseOAuthAuthorizationServer(oAuthServerOptions);
            //appBuilder.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());


            var corsPolicy = new CorsPolicy
            {
                AllowAnyHeader = true,
                AllowAnyMethod = true,
                Origins = { "http://127.0.0.1", "https://127.0.0.1" } //"http://192.168.100.171", "https://192.168.100.171"
            };

            appBuilder.UseCors(new CorsOptions
            {
                PolicyProvider = new CorsPolicyProvider
                {
                    PolicyResolver = context => Task.FromResult(corsPolicy)
                }
            });

            HttpConfiguration config = new HttpConfiguration();

            //config.SuppressDefaultHostAuthentication();
            //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            //config.Filters.Add(new AuthorizeAttribute());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "WebApiClient API");
                c.IncludeXmlComments(GetXmlCommentsPath());
                c.PrettyPrint();

                //  c.OperationFilter<AuthorizeCheckOperationFilter>();
            })

            .EnableSwaggerUi(c =>
            {
                // http://127.0.0.1:54322/swagger/ui/index
                //  c.EnableApiKeySupport("Authorization", "header");
            });

            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.Formatters.JsonFormatter.SerializerSettings.ConstructorHandling = Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor;

            appBuilder.UseWebApi(config);
        }

        private static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\WebApi.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}