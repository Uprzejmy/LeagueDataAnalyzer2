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
using System.Windows.Shapes;

namespace LeagueDataAnalyzer2.View
{
    /// <summary>
    /// Interaction logic for Match.xaml
    /// </summary>
    public partial class MatchHistory : Window
    {
        public MatchHistory()
        {
            InitializeComponent();
        }

        private void BackToSearchClick(object sender, RoutedEventArgs e)
        {
            var window = new PlayerSearch { DataContext = new ViewModelPlayerSearch() };
            window.Show();
            this.Close();
        }
    }
}
