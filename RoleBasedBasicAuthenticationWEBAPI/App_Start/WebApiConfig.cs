using RoleBasedBasicAuthenticationWEBAPI.Models;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RoleBasedBasicAuthenticationWEBAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //configure basic authentication for application
            //you can configure at controller and action method level
            config.Filters.Add(new BasicAuthenticationAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            //following 2 line will enable CORS globally for the entire application i.e. for all controllers and action methods.
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            //config.EnableCors(); call like this if you want to apply CORS at controller/action level.

            //Parameters of EnableCorsAttribute
            //Origins: A comma-separated list of origins that are allowed to access the resource. For example “https://www.dotnettutorials.net, https://www.something.com” will only allow ajax calls from these 2 websites. All the others will be blocked. Use “*” to allow all
            //Headers: A comma-separated list of headers that are supported by the resource.For example “accept,content - type, origin” will only allow these 3 headers.Use “*” to allow all.Use the null or empty string to allow none
            //Methods: A comma-separated list of methods that are supported by the resource.For example “GET, POST” only allows Get and Post and blocks the rest of the methods. Use “*” to allow all.Use a null or empty string to allow none
        }
    }
}
