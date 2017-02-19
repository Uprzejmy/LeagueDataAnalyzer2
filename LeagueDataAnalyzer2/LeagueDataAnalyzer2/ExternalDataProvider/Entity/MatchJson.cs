using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider.Entity
{
    class MatchJson
    {
        [JsonProperty("region")]
        public string region { get; set; }

        [JsonProperty("platformId")]
        public string platformId { get; set; }

        [JsonProperty("matchId")]
        public long matchId { get; set; }

        [JsonProperty("champion")]
        public long champion { get; set; }

        [JsonProperty("queue")]
        public string queue { get; set; }

        [JsonProperty("season")]
        public string season { get; set; }

        [JsonProperty("timestamp")]
        public long timestamp { get; set; }

        [JsonProperty("lane")]
        public string lane { get; set; }

        [JsonProperty("role")]
        public string role { get; set; }
    }
}
