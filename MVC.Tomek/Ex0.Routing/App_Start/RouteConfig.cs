using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ex0.Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("ShowTime", "jest/godzina/{id}", new { controller = "Home", action = "Time", id = UrlParameter.Optional });
            routes.MapRoute("ShowDate", "jest/dzien/{id}", new { controller = "Home", action = "Date", id = UrlParameter.Optional });
            routes.MapRoute("ShowDateTime", "jest/{id}", new { controller = "Home", action = "DateTime", id = UrlParameter.Optional });
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "MainPage", id = UrlParameter.Optional }
            );
        }
    }
}
