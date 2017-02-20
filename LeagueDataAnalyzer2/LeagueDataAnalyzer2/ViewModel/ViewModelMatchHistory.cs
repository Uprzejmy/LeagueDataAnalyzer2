using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using LeagueDataAnalyzer2.Model.Entity;
using LeagueDataAnalyzer2.Model;

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

        string _textProperty1;
        public string TextProperty1
        {
            get
            {
                return _textProperty1;
            }
            set
            {
                if (_textProperty1 != value)
                {
                    _textProperty1 = value;
                    RaisePropertyChanged("TextProperty1");
                }
            }
        }

        //to be removed
        public ViewModelMatchHistory()
        {
            if (data == null)
                data = new DataAccessProxy();

            TextProperty1 = "test";
        }

        public ViewModelMatchHistory(string username)
        {
            if (data == null)
                data = new DataAccessProxy();

            try
            {
                _player = data.GetPlayerByName(username);
                TextProperty1 = _player.ToString();
            }
            catch(Exception)
            {
                TextProperty1 = "Nieznaleziono gracza";
            }
            
        }
    }
}
