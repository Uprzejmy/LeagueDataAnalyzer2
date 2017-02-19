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

        public static string GetMatchesByPlayerId(string id="26885974")
        {
            string result = ApiConnector.GetDataFromUrl(UrlsRepository.GetMatchesByPlayerId(id));

            string directory = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApp‌​licationData),"LeagueDataAnalyzer2");
            Directory.CreateDirectory(directory);

            File.WriteAllText(Path.Combine(directory,"ExampleData.txt"), result);

            return result;
        }

        public static string GetMatchesStringByPlayerIdFromLocal()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApp‌​licationData), "LeagueDataAnalyzer2", "ExampleData.txt");
            string readText = File.ReadAllText(path);

            return readText;
        }

        

        public static IEnumerable<MatchJson> GetMatchesByPlayerIdFromLocal()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApp‌​licationData), "LeagueDataAnalyzer2", "ExampleData.txt");
            string json = File.ReadAllText(path);

            return MatchDeserializer.DeserializeMatch(json).Matches;
        }
    }
}
