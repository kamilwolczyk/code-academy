using System.Collections.Generic;
using Hc.FootballApp.Data.Entities;

namespace Hc.FootballApp.Services.FootballTeams
{
    public interface IFootballTeamService
    {
        IEnumerable<FootballTeam> GetAll();
    }
}