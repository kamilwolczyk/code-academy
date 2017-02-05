using HC.Tomek.Ex6.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Tomek.Ex6.Forms.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HelloWorld()
        {
            Person person = new Person
            {
                FirstName = "Kamil",
                Surname = "Wolczyk"
            };
            
            return Json(person, JsonRequestBehavior.AllowGet);
        }
    }
}