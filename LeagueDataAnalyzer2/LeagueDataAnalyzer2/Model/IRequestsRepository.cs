using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model
{
    interface IRequestsRepository
    {
        string GetPlayerByName(string name);
        string GetMatchesByPlayerId(string id);
    }
}
