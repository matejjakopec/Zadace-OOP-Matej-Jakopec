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

namespace zad5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> names = new List<string>();
        List<string> seasons = new List<string>();
        List<string> episodes = new List<string>();
        Dictionary<int, string> output = new Dictionary<int, string>();
        Dictionary<int, string> seasonDic = new Dictionary<int, string>();
        int id, idSeason;
        public MainWindow()
        {
            InitializeComponent();
            ResultsList.ItemsSource = names;
            SeasonList.ItemsSource = seasons;
            EpisodeList.ItemsSource = episodes;
        }

        private void SearchSeries_Click(object sender, RoutedEventArgs e)
        {
            names.Clear();
            seasons.Clear();
            string input = SearchInput.Text;
            output = ShowHelper.SearchShowByName(input);
            foreach (KeyValuePair<int, string> item in output)
            {
                names.Add(item.Value);
            }
            ResultsList.Items.Refresh();
        }

        private void ResultsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedShow = ResultsList.SelectedItem as string;
            foreach (KeyValuePair<int, string> item in output)
            {
                if (item.Value == selectedShow)
                    id = item.Key;
            }
            seasonDic = ShowHelper.ShowSeason(id);
            ShowInfo info = new ShowInfo(id);
            foreach (KeyValuePair<int, string> item in seasonDic)
            {
                seasons.Add(item.Value);
            }
            SeriesInfo.Text = info.ToString();
            names.Clear();
            ResultsList.Items.Refresh();
            SeasonList.Items.Refresh();
            
        }

        private void SeasonList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            episodes.Clear();
            var selectedSeason = SeasonList.SelectedItem as string;
            foreach (KeyValuePair<int, string> item in seasonDic)
            {
                if (item.Value == selectedSeason)
                    idSeason = item.Key;
            }
            List<string> copy = ShowHelper.ShowEpisodes(idSeason);
            foreach (string item in copy)
            {
                episodes.Add(item);
            }
            EpisodeList.Items.Refresh();
        }
    }
}
