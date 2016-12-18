using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string ShowHelloWorld()
        {
            return "Hello world";
        }
        public string Test()
        {
            return "Dupa";
        }
    }
}