using System.Web.Mvc;
using HC.Radek.Ex5.Routing.Models;

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