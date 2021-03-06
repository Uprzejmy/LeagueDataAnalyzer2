﻿using LeagueDataAnalyzer2.Model.Transformers;
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
        long _matchId;
        long _champion;
        string _queue;
        string _season;
        DateTime _date;
        
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

        public string ChampionName
        {
            get { return ChampionIdToName.GetName(_champion); }
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

        public override bool Equals(Object obj)
        {
            Match match = obj as Match;
            if (match == null)
                return false;
            
            return this._matchId.Equals(match.MatchId);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "id: " + _matchId.ToString() + " " + "queue: " + _queue.ToString();
        }
    }
}
