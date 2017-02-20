using LeagueDataAnalyzer2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LeagueDataAnalyzer2.ViewModel
{
    class ViewModelPlayerSearch : ViewModelBase
    {
        string _summonerName;
        public string SummonerName
        {
            get
            {
                return _summonerName;
            }
            set
            {
                if (_summonerName != value)
                {
                    _summonerName = value;
                    RaisePropertyChanged("SummonerName");
                }
            }
        }

    }
}
