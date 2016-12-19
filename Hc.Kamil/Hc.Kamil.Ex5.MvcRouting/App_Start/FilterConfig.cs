using System.Web.Mvc;

namespace Hc.Kamil.Ex5.MvcRouting
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}