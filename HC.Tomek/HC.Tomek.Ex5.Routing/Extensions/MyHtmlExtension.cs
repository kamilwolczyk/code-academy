using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Tomek.Ex5.Routing.Extensions
{
    public static class MyHtmlExtension
    {
        public static MvcHtmlString HelloWorld(this HtmlHelper html, int x)
        {
            
            return new MvcHtmlString("<div>Hello world!</div>");
        }
    }
}