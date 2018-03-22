using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MessageTransfer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web Api Enable Core Live
            //var corsAttr = new EnableCorsAttribute("http://tj.nextpageit.net", "*", "*");
            // Web Api Enable Core Local
            var corsAttr = new EnableCorsAttribute("*", "", "");
            config.EnableCors(corsAttr);
            // Web API routes
            config.MapHttpAttributeRoutes();
          
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
