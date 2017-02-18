using System;
using System.IO;
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
            string result = ApiConnector.GetDataFromUrl(UrlsRepository.GetMatchesByPlayerId(id));

            string directory = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApp‌​licationData),"LeagueDataAnalyzer2");
            Directory.CreateDirectory(directory);

            File.WriteAllText(Path.Combine(directory,"ExampleData.txt"), result);

            return result;
        }

        public static string GetMatchesByPlayerIdFromLocal()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApp‌​licationData), "LeagueDataAnalyzer2", "ExampleData.txt");
            string readText = File.ReadAllText(path);

            return readText;
        }
    }
}
