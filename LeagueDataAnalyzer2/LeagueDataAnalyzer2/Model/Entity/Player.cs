using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model.Entity
{
    class Player : INotifyPropertyChanged
    {
        protected long _id;
        protected string _username;
        protected int _profileIconId;
        protected int _summonerLevel;
        protected HashSet<Match> _matches = new HashSet<Match>();

        public DateTime lastExternalApiCall = DateTime.Today.AddDays(-1); //to make sure the first call will call the external api

        public long Id
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

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    RaisePropertyChanged("Username");
                }
            }
        }

        public int ProfileIconId
        {
            get
            {
                return _profileIconId;
            }
            set
            {
                if (_profileIconId != value)
                {
                    _profileIconId = value;
                    RaisePropertyChanged("ProfileIconId");
                }
            }
        }

        public int SummonerLevel
        {
            get
            {
                return _summonerLevel;
            }
            set
            {
                if (_summonerLevel != value)
                {
                    _summonerLevel = value;
                    RaisePropertyChanged("SummonerLevel");
                }
            }
        }

        public HashSet<Match> Matches { get { return _matches; } }

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
            Player player = obj as Player;
            if (player == null)
                return false;

            return this._id.Equals(player.Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "id: " + _id.ToString() + " " + "username: " + _username.ToString();
        }
    }
}
