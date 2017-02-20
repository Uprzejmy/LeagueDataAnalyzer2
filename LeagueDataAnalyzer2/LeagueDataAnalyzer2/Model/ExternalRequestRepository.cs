using LeagueDataAnalyzer2.Model.Entity;
using LeagueDataAnalyzer2.Model.Transformers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model
{
    class ExternalRequestRepository : IRequestsRepository
    {
        Data database = Data.Instance;

        public IEnumerable<Match> GetMatchesByPlayerId(long id)
        {
            Player player = database.Players.Where(x => x.Id == id).FirstOrDefault();

            // Console.WriteLine("External api: GetMatchesByPlayerIdFromLocal");
            foreach (ExternalDataProvider.Entity.MatchJson matchData in ExternalDataProvider.RequestsRepository.GetMatchesByPlayerId(id.ToString()))
            {
                Match match = new MatchTransformer(matchData).Match;
                // Console.WriteLine("Match: " + match.ToString());
                if (!player.Matches.Any(x => x.Equals(match)))
                {
                    player.Matches.Add(match);
                }
            }

            player.lastExternalApiCall = DateTime.Now;

            return player.Matches;
        }

        public Player GetPlayerByName(string name)
        {
            // Console.WriteLine("External api: GetSummonerByName");

            Player player = new PlayerTransformer(ExternalDataProvider.RequestsRepository.GetSummonerByName(name)).Player;

            if (player != null)
            {
                database.Players.Add(player);
                return player;
            }

            // player not found
            throw new NotImplementedException();
        }
    }
}
