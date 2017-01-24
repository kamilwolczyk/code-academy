using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HC.Radek.Ex5.Routing.Extensions
{
    public static class MyHTMLExtensions
    {
        public static MvcHtmlString MyHelloWorld (this HtmlHelper htmlHelper, int count)
        {
            StringBuilder MyString = new StringBuilder();
            for(var i = 0; i< count; i++)
            {
                MyString.Append("<div>Hello, world!</div>");
            }
            return new MvcHtmlString(MyString.ToString());
        }
    }
}