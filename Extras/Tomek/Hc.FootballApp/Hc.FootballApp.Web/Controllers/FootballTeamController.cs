using Hc.FootballApp.Services.FootballTeams;
using Hc.FootballApp.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Hc.FootballApp.Web.Controllers
{
    public class FootballTeamController : Controller
    {
        IFootballTeamService _footballTeamService;
        public FootballTeamController()
        {
            _footballTeamService = new MockFootballTeamService();

        }
        public ActionResult List()
        {
            var model = _footballTeamService.GetAll();
            List<FootballTeamModel> newModel = new List<FootballTeamModel>();
            foreach (var item in model)
            {
                newModel.Add(new FootballTeamModel { Id=item.Id, Name=item.Name });
            }
            return View(newModel.AsEnumerable());
        }
    }
}