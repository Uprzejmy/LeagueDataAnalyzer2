using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using LeagueDataAnalyzer2.Model.Entity;
using LeagueDataAnalyzer2.DataProvider;

namespace LeagueDataAnalyzer2.ViewModel
{
    class ViewModelMain : ViewModelBase
    {
        public ObservableCollection<Match> Matches { get; set; }

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
            Matches = new ObservableCollection<Match>
            {
                new Match { Id=10, MatchId=12345 },
                new Match { Id=11, MatchId=12346 },
                new Match { Id=12, MatchId=12347 },
            };

            string riotKey = ConfigurationManager.AppSettings.Get("riot_key");
            //TextProperty1 = ApiConnector.GetDataFromUrl("https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/by-name/Uprzejmy?api_key=" + riotKey); // uprzejmy: 26885974
            //TextProperty1 = RequestsRepository.GetPlayerByName("Uprzejmy"); // uprzejmy: 26885974
            TextProperty1 = RequestsRepository.GetMatchesByPlayerId("26885974");
            //TextProperty1 = RequestsRepository.GetPlayerByName("Uprzejmy");
        }
    }
}
