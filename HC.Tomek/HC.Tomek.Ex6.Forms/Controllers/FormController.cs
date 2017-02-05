using HC.Tomek.Ex6.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Tomek.Ex6.Forms.Controllers
{
    public class FormController : Controller
    {
        
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(Person person)
        {
            if (!ModelState.IsValid)
                return View();
  
            return View("Confirmation");
        }
    }
}