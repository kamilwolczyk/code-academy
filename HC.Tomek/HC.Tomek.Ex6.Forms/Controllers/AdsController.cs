using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Tomek.Ex6.Forms.Controllers
{
    public class AdsController : Controller
    {
        // GET: Ads
        public ActionResult Index()
        {
            string reklamy = "Reklamy!!! (wywolanie akcji w kontrolerze)";
            return PartialView("Index",reklamy);
        }
    }
}