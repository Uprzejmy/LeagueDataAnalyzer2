using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueDataAnalyzer2.Model.Entity;
using LeagueDataAnalyzer2.Model.Transformers;

namespace LeagueDataAnalyzer2.Model
{
    // this class implements IRequestRepository since it provides inteligent way to access data
    class DataAccessProxy : IRequestsRepository
    {
        int externalCallMinutesInterval = 60; //this parameter can change for various reasons (move to AppSetting maybe)
        Data database = Data.Instance;

        public IEnumerable<Match> GetMatchesByPlayerId(long id)
        {
            Player player = database.Players.Where(x => x.Id == id).FirstOrDefault();
            // Console.WriteLine("Player: " + player.ToString());

            IRequestsRepository repository; // Strategy pattern

            if (player == null || RefreshRequired(player.lastExternalApiCall))
            {
                repository = new ExternalRequestRepository();
            }
            else
            {
                repository = new InternalRequestRepository();
            }

            return repository.GetMatchesByPlayerId(id);
        }

        public Player GetPlayerByName(string name)
        {
            Player player = database.Players.Where(x => x.Username.ToLower() == name.ToLower()).FirstOrDefault();

            IRequestsRepository repository; // Strategy pattern

            if (player == null)
            {
                repository = new ExternalRequestRepository();
            }
            else
            {
                repository = new InternalRequestRepository();
            }

            return repository.GetPlayerByName(name);
        }

        private bool RefreshRequired(DateTime lastExternalApiCall)
        {
            return lastExternalApiCall.AddMinutes(externalCallMinutesInterval) < DateTime.Now ? true : false;
        }
    }
}
