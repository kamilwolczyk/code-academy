using Hc.FootballApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hc.FootballApp.Services.FootballTeams
{
    public class MockFootballTeamService : IFootballTeamService
    {
        public IEnumerable<FootballTeam> GetAll()
        {
            return new List<FootballTeam>
            {
                new FootballTeam()
                {
                    Id=1,
                    EstablishedYear=1749,
                    Name="Real Madrit"
                },
                new FootballTeam()
                {
                    Id=2,
                    EstablishedYear=1649,
                    Name="FC Barcelona"
                },
                new FootballTeam()
                {
                    Id=3,
                    EstablishedYear=1949,
                    Name="Górnik Zabrze"
                }
            };
        }
    }
}
