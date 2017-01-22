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
            if (!isEarlierThanToday(person.BirthDate))
            {
                ModelState.AddModelError("age", "You have to be older than 1 day");
            }
            if (!isOlderThan1900(person.BirthDate))
            {
                ModelState.AddModelError("age", "Birth date cannot be earlier than 1900-01-01");
            }

            //pola imie nazwisko wiek adres. po przeladowaniu komunikat dziekujemy za zakupy w naszym sklepie i pod spodem tekst wysyłamy towar do.... + formularza ma nie byc
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            else
            {
                if (isAdult(person.BirthDate))
                {
                    return View("ConfirmationView", person);
                }
                else{
                    return View("NotAdultView", person);
                }
                
            }
            
        }

        private bool isEarlierThanToday(string personBirthDate)
        {
            DateTime now = DateTime.Now;
            List<string> s = new List<string>(personBirthDate.Split(new string[] { "-" }, StringSplitOptions.None));
            DateTime bDate = new DateTime(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2]), 23, 59, 59);

            int result = DateTime.Compare(now, bDate);

            return result > 0 ? true : false;
  
        }

        private bool isOlderThan1900(string personBirthDate)
        {
            List<string> s = new List<string>(personBirthDate.Split(new string[] { "-" }, StringSplitOptions.None));
            DateTime bDate = new DateTime(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2]), 0, 0, 0);
            DateTime sDate = new DateTime(1900,1,1, 0, 0, 0);
            int result = DateTime.Compare(sDate, bDate);
            return result < 0 ? true : false;
        }

        private bool isAdult(string personBirthDate)
        {
            DateTime now = DateTime.Now;
            List<string> s = new List<string>(personBirthDate.Split(new string[] { "-" }, StringSplitOptions.None));
            DateTime bDate = new DateTime(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2]), 23, 59, 59);
            return now.Year - bDate.Year > 18 ? true : false;

        }


    }
}