using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueDataAnalyzer2.Model.Entity;
using LeagueDataAnalyzer2.Model.Exceptions;

namespace LeagueDataAnalyzer2.Model
{
    class InternalRequestRepository : IRequestsRepository
    {
        Data database = Data.Instance;

        public IEnumerable<Match> GetMatchesByPlayerId(long id)
        {
            Player player = database.Players.Where(x => x.Id == id).FirstOrDefault();

            return player.Matches;
        }

        public Player GetPlayerByName(string name)
        {
            // Console.WriteLine("number of players in internal database: " + database.Players.Count());
            Player player = database.Players.Where(x => x.Username.ToLower() == name.ToLower()).FirstOrDefault();
            
            if(player != null)
            {
                return player;
            }

            throw new ElementNotFoundException();
        }
    }
}
