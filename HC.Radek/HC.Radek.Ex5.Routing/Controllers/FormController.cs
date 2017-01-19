using HC.Radek.Ex5.Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Radek.Ex5.Routing.Controllers
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
            //pola imie nazwisko wiek adres. po przeladowaniu komunikat dziekujemy za zakupy w naszym sklepie i pod spodem tekst wysyłamy towar do.... + formularza ma nie byc
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            else
            {
                return View("ConfirmationView",person);
            }
            
        }
    }
}