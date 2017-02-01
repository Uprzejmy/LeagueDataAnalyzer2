using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model.Entity
{
    class Match : INotifyPropertyChanged
    {
        int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        int _matchId;
        public int MatchId
        {
            get
            {
                return _matchId;
            }
            set
            {
                if (_matchId != value)
                {
                    _matchId = value;
                    RaisePropertyChanged("MatchId");
                }
            }
        }


        void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
