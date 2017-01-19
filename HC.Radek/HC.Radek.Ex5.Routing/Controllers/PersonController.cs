using HC.Radek.Ex5.Routing.Models;
using HC.Radek.Ex5.Routing.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Radek.Ex5.Routing.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index(int? id)
        {
            PersonService personService = new PersonService();
            Person person = personService.GetPerson(new Person(), id);
            return Json(person, JsonRequestBehavior.AllowGet);
        }

        
    }
}