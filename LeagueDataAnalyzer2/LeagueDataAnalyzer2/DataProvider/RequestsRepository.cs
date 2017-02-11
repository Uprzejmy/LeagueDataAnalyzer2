using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.DataProvider
{
    class RequestsRepository
    {
        public static string GetPlayerByName(string name)
        {
            return ApiConnector.GetDataFromUrl(UrlsRepository.GetPlayerByName(name));
        }

        public static string GetMatchesByPlayerId(string id)
        {
            return ApiConnector.GetDataFromUrl(UrlsRepository.GetMatchesByPlayerId(id));
        }
    }
}
