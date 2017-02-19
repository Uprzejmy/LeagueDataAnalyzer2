using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueDataAnalyzer2.Model.Entity;

namespace LeagueDataAnalyzer2.Model
{
    class DataHandler
    {
        public static string GetMatchesData()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApp‌​licationData), "LeagueDataAnalyzer2", "ExampleData.txt");
            string readText = File.ReadAllText(path);

            return readText;
        }

        public static void FillMatchData()
        {
            Data database = Data.Instance;

            foreach(DataProvider.Entity.MatchJson matchData in DataProvider.RequestsRepository.GetMatchesByPlayerIdFromLocal())
            {
                database.Matches.Add(new MatchTransformer(matchData).Match);
            }
        }
      
    }
}
