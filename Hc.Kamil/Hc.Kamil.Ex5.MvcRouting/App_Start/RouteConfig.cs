using System.Web.Mvc;
using System.Web.Routing;

namespace Hc.Kamil.Ex5.MvcRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Date", "jest/dzien/{format}", new { controller = "Date", action = "Date", format = UrlParameter.Optional });
            routes.MapRoute("Hour", "jest/godzina/{format}", new { controller = "Date", action = "Hour", format = UrlParameter.Optional });
            routes.MapRoute("DateTime", "jest/{format}", new { controller = "Date", action = "DateTime", format = UrlParameter.Optional });
            routes.MapRoute("WelcomePage", "{controller}/{action}", new { controller = "Date", action = "Hello" });
        }
    }
}