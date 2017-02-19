using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueDataAnalyzer2.DataProvider.Entity;

namespace LeagueDataAnalyzer2.DataProvider
{
    class RequestsRepository
    {
        public static string GetPlayerByName(string name)
        {
            return ApiConnector.GetDataFromUrl(UrlsRepository.GetPlayerByName(name));
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

            return Deserializer.MatchDeserializer.DeserializeMatch(json);
        }
    }
}
