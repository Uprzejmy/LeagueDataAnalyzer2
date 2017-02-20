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
    class ViewModelMain : ViewModelBase
    {
        public IEnumerable<Match> Matches
        {
            get
            {
                if (data == null)
                    data = new DataAccessProxy();
                
                return data.GetMatchesByPlayerId(26885974);
            }
        }

        DataAccessProxy data;

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

        public ViewModelMain()
        {
            if (data == null)
                data = new DataAccessProxy();

            try
            {
                Player player = data.GetPlayerByName("uprzejmy432");
                TextProperty1 = player.ToString();
            }
            catch(Exception)
            {
                TextProperty1 = "Nieznaleziono gracza";
            }
            
        }
    }
}
