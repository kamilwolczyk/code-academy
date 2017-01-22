using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HC.Tomek.Ex5.Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("ShowTime", "jest/godzina/{format}", new { controller = "Home", action = "Time", format = UrlParameter.Optional });
            routes.MapRoute("ShowDate", "jest/dzien/{format}", new { controller = "Home", action = "Date", format = UrlParameter.Optional });
            routes.MapRoute("ShowDateTime", "jest/{format}", new { controller = "Home", action = "DateTime", format = UrlParameter.Optional });
            routes.MapRoute("ShowPerson", "osoba/{id}", new { controller = "Person", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute("ShowCar", "autka", new { controller = "Car", action = "Index" });
            routes.MapRoute("ShowForm", "formularz", new { controller = "Form", action = "Form" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "MainPage", id=UrlParameter.Optional}
            );
        }
    }
}
