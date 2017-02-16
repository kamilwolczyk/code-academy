using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Radek.Ex5.Routing.Controllers
{
    public class AdsController : Controller
    {
        // GET: Ads
        public ActionResult Index()
        {
            return PartialView("Index","Moja reklama testowa dynamiczna");
        }
    }
}