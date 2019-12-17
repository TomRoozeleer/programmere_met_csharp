using HighSalesEF.Repositories;
using System;
using System.Windows;

namespace HighSalesEF
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
            artistRepository = new ArtistRepository();
        }

        private void salesButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double minimumSales = Convert.ToDouble(minimumTextBox.Text);
                salesListView.ItemsSource = artistRepository.GetAllSalesAbove(minimumSales);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Gelieve een getal in de te geven!");
            }
        }
    }
}
