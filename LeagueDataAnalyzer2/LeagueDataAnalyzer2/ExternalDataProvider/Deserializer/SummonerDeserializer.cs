using LeagueDataAnalyzer2.ExternalDataProvider.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider.Deserializer
{
    class SummonerDeserializer
    {
        public static SummonerJson DeserializeSummoner(string json)
        {
            try
            {
                Dictionary<string, SummonerJson> dictionary = JsonConvert.DeserializeObject<Dictionary<string, SummonerJson>>(json);
                return dictionary.First().Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
