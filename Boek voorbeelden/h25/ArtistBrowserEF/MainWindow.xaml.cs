using ArtistBrowserEF.Models;
using ArtistBrowserEF.Repositories;
using System.Windows;

namespace ArtistBrowserEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IArtistRepository artistRepository;

        public MainWindow()
        {
            InitializeComponent();

            artistRepository = new EFArtistRepository();
            artistListView.ItemsSource = artistRepository.GetAll();

            artistListView.SelectedIndex = 0;
        }

        private void artistListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            this.DataContext = artistListView.SelectedItem;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            artistRepository.Update((Artist)artistListView.SelectedItem);
        }
    }
}
