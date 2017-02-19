using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueDataAnalyzer2.Model.Entity;
using LeagueDataAnalyzer2.Model.Transformers;

namespace LeagueDataAnalyzer2.Model
{
    class DataAccessProxy : IRequestsRepository
    {
        int externalCallMinutesInterval = 60; //this parameter can change for various reasons (move to AppSetting maybe)
        IRequestsRepository RequestRepository;
        Data database = Data.Instance;


        public DataAccessProxy()
        {
            RequestRepository = new RequestRepository();
        }

        public IEnumerable<Match> GetMatchesByPlayerId(long id)
        {
            Player player = database.Players.Where(x => x.Id == id).FirstOrDefault();
            
            // Console.WriteLine("Player: " + player.ToString());

            if (RefreshRequired(player.lastExternalApiCall))
            {
                // Console.WriteLine("External api: GetMatchesByPlayerIdFromLocal");
                foreach (ExternalDataProvider.Entity.MatchJson matchData in ExternalDataProvider.RequestsRepository.GetMatchesByPlayerIdFromLocal())
                {
                    Match match = new MatchTransformer(matchData).Match;
                    // Console.WriteLine("Match: " + match.ToString());
                    if(!player.Matches.Any(x => x.Equals(match)))
                    {
                        player.Matches.Add(match);
                    }
                }

                player.lastExternalApiCall = DateTime.Now;
            }

            return RequestRepository.GetMatchesByPlayerId(id);
        }

        public Player GetPlayerByName(string name)
        {
            // Console.WriteLine("number of players in internal database: " + database.Players.Count());
            
            Player player = database.Players.Where(x => x.Username == name).FirstOrDefault();
            
            if(player == null)
            {
                // Console.WriteLine("External api: GetSummonerByName");
                player = new PlayerTransformer(ExternalDataProvider.RequestsRepository.GetSummonerByName(name)).Player;
                database.Players.Add(player);
            }

            // Console.WriteLine("number of players in internal database: " + database.Players.Count());

            return RequestRepository.GetPlayerByName(name);
        }

        private bool RefreshRequired(DateTime lastExternalApiCall)
        {
            return lastExternalApiCall.AddMinutes(externalCallMinutesInterval) < DateTime.Now ? true : false;
        }
    }
}
