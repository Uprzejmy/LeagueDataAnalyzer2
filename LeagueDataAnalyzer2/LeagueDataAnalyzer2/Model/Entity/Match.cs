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
        long _matchId;
        long _champion;
        string _queue;
        string _season;
        DateTime _date;

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

        
        public long MatchId
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

        public long Champion
        {
            get
            {
                return _champion;
            }
            set
            {
                if (_champion != value)
                {
                    _champion = value;
                    RaisePropertyChanged("Champion");
                }
            }
        }

        public string Queue
        {
            get
            {
                return _queue;
            }
            set
            {
                if (_queue != value)
                {
                    _queue = value;
                    RaisePropertyChanged("Queue");
                }
            }
        }

        public string Season
        {
            get
            {
                return _season;
            }
            set
            {
                if (_season != value)
                {
                    _season = value;
                    RaisePropertyChanged("Season");
                }
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    RaisePropertyChanged("Date");
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
