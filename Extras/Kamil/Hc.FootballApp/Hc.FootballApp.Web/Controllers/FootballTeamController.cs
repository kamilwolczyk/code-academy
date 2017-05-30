using System.Web.Mvc;

namespace Hc.FootballApp.Web.Controllers
{
    public class FootballTeamController : Controller
    {
        public ActionResult List()
        {
            return View();
        }
    }
}