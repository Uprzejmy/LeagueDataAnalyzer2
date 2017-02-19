using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider.Entity
{
    class MatchesJson
    {
        [JsonProperty("matches")]
        public List<MatchJson> Matches { get; set; }
            
        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }

        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }
    }
}
