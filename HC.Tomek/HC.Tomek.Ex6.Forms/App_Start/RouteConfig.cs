using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HC.Tomek.Ex6.Forms
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute("Form", "Form", new { controller = "Form", action = "Form" });
            routes.MapRoute("About-us", "About-us", new { controller = "AboutUs", action = "AboutUs" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Form", action = "Form"}
            );
        }
    }
}
