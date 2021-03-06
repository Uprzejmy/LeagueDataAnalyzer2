﻿using LeagueDataAnalyzer2.ExternalDataProvider.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider.Deserializer
{
    class MatchDeserializer
    {
        public static MatchesJson DeserializeMatch(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<MatchesJson>(json);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
