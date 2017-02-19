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
            //DataProvider.RequestsRepository.GetMatchesByPlayerId();
            DataHandler.FillMatchData();

            Matches = new ObservableCollection<Match>();

            Data database = Data.Instance;
            foreach(Match match in database.Matches)
            {
                Matches.Add(match);
            }

            //TextProperty1 = DataHandler.GetMatchesData();
        }
    }
}
