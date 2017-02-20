using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider
{
    class UrlsRepository
    {
        private static string riotKey = "?api_key=" + ConfigurationManager.AppSettings.Get("riot_key");

        public static string GetSummonerByName(string name)
        {
            return "https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/by-name/" + name + riotKey;
        }

        public static string GetSummonerById(string id)
        {
            return "https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/" + id + riotKey;
        }

        public static string GetMatchesByPlayerId(string id)
        {
            return "https://eune.api.pvp.net/api/lol/eune/v2.2/matchlist/by-summoner/" + id + riotKey;
        }
    }
}
