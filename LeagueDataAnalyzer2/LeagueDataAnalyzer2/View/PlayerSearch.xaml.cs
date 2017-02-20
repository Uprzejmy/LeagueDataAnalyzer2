using LeagueDataAnalyzer2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeagueDataAnalyzer2.View
{
    /// <summary>
    /// Interaction logic for PlayerSearch.xaml
    /// </summary>
    public partial class PlayerSearch : Window
    {
        public PlayerSearch()
        {
            InitializeComponent();
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            var window = new MatchHistory { DataContext = new ViewModelMatchHistory(SummonerName.Text) };
            window.Show();
            this.Close();
        }

    }
}
