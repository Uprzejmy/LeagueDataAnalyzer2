using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider.Entity
{
    class SummonerJson
    {
        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("profileIconId")]
        public int profileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public long revisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public int summonerLevel { get; set; }
    }
}
