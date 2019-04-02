using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //   "Test",
            //   "Iceland/{Name}/{Slide}",
            //   new {controller = "Catalog", action = "Test", Slide = UrlParameter.Optional },
            //   new { Slide = @"\d{2}"}
            //   );

         routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Get", id = UrlParameter.Optional }
            );
        }
    }
}
