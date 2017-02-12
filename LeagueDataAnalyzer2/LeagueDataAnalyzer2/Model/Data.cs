using LeagueDataAnalyzer2.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model
{
    class Data
    {
        public IEnumerable<Match> Matches = new HashSet<Match>();
        public IEnumerable<Player> Players = new HashSet<Player>();

        private static Data data = null;

        public static Data Instance { get { if (data == null) data = new Data(); return data; } }

        private Data()
        {

        }
    }
}
