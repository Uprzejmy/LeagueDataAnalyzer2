using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model.Entity
{
    class NullPlayer : Player
    {
        public NullPlayer()
        {
            _id = 0;
            _summonerLevel = 0;
            _username = "Nie znaleziono gracza";
        }
    }
}
