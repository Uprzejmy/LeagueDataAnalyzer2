using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using LeagueDataAnalyzer2.Model.Entity;
using LeagueDataAnalyzer2.Model;
using LeagueDataAnalyzer2.View;

namespace LeagueDataAnalyzer2.ViewModel
{
    class ViewModelMatchHistory : ViewModelBase
    {
        public IEnumerable<Match> Matches
        {
            get
            {
                return data.GetMatchesByPlayerId(_player.Id);
            }
        }

        DataAccessProxy data;

        Player _player;
        
        public string PlayerName
        {
            get
            {
                return _player.Username.ToString();
            }
            set
            {
                RaisePropertyChanged("PlayerName");
            }
        }
        
        public string PlayerLevel
        {
            get
            {
                return _player.SummonerLevel.ToString();
            }
            set
            {
                RaisePropertyChanged("PlayerLevel");
            }
        }

        //to be removed
        public ViewModelMatchHistory()
        {
            if (data == null)
                data = new DataAccessProxy();
            
        }

        public ViewModelMatchHistory(string username)
        {
            if (data == null)
                data = new DataAccessProxy();

            try
            {
                _player = data.GetPlayerByName(username);
            }
            catch(Exception)
            {
                _player = new NullPlayer();
            }
            
        }
    }
}
