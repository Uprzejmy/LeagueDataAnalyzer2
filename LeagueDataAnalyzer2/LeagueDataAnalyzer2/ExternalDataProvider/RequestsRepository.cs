using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueDataAnalyzer2.ExternalDataProvider.Entity;
using LeagueDataAnalyzer2.ExternalDataProvider.Deserializer;

namespace LeagueDataAnalyzer2.ExternalDataProvider
{
    class RequestsRepository
    {
        public static SummonerJson GetSummonerByName(string name)
        {
            string json = ApiConnector.GetDataFromUrl(UrlsRepository.GetSummonerByName(name));

            return SummonerDeserializer.DeserializeSummoner(json);
        }

        public static SummonerJson GetSummonerById(string id)
        {
            string json = ApiConnector.GetDataFromUrl(UrlsRepository.GetSummonerById(id));

            return SummonerDeserializer.DeserializeSummoner(json);
        }

        public static IEnumerable<MatchJson> GetMatchesByPlayerId(string id)
        {
            string json = ApiConnector.GetDataFromUrl(UrlsRepository.GetMatchesByPlayerId(id));

            return MatchDeserializer.DeserializeMatch(json).Matches;
        }

        //for testing purposes, to not call api the entire time
        public static IEnumerable<MatchJson> GetMatchesByPlayerIdFromLocal()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApp‌​licationData), "LeagueDataAnalyzer2", "ExampleData.txt");
            string json = File.ReadAllText(path);

            return MatchDeserializer.DeserializeMatch(json).Matches;
        }
    }
}
