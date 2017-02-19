using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueDataAnalyzer2.Model.Entity;

namespace LeagueDataAnalyzer2.Model.Transformers
{
    class PlayerTransformer
    {
        Player _player;
        public Player Player
        {
            get
            {
                return _player;
            }
        }

        public PlayerTransformer(ExternalDataProvider.Entity.SummonerJson summonerData)
        {
            _player = new Player();
            _player.Id = summonerData.id;
            _player.Username = summonerData.name;
            _player.SummonerLevel = summonerData.summonerLevel;
            _player.ProfileIconId = summonerData.profileIconId;
        }
    }
}
