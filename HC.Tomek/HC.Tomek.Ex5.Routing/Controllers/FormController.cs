using HC.Tomek.Ex5.Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Tomek.Ex5.Routing.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(Person person)
        {
            if (ModelState.IsValid)
            {
                return View("ConfirmationView",person);
            }
            //write to database

            
            return View();
        }
    }
}