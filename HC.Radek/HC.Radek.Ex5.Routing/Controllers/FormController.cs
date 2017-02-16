using HC.Radek.Ex5.Routing.Models;
using System.Web.Mvc;

namespace HC.Radek.Ex5.Routing.Controllers
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
            return !ModelState.IsValid ? View(person) : View("ConfirmationView", person);
        }

    }
}