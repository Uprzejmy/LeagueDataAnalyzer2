using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueDataAnalyzer2.Model.Entity;

namespace LeagueDataAnalyzer2.Model
{
    interface IRequestsRepository
    {
        Player GetPlayerByName(string name);
        IEnumerable<Match> GetMatchesByPlayerId(long id);
    }
}
