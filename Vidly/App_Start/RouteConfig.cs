 using System;
using System.Collections.Generic;
using System.Linq;
 using System.Management.Instrumentation;
 using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                                    //Most specific to most generic
                                 //Position matters 

                                 routes.MapMvcAttributeRoutes();

            

                 

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
