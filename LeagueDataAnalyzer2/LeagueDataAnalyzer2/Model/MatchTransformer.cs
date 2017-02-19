using LeagueDataAnalyzer2.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model
{
    class MatchTransformer
    {
        Match _match;
        public Match Match
        {
            get
            {
                return _match;
            }
        }

        public MatchTransformer(DataProvider.Entity.MatchJson MatchData)
        {
            _match = new Match();
            _match.MatchId = MatchData.matchId;
            _match.Champion = MatchData.champion;
            _match.Queue = MatchData.queue;
            _match.Season = MatchData.season;
            _match.Date = DateTimeOffset.FromUnixTimeMilliseconds(MatchData.timestamp).DateTime;
        }
    }
}
