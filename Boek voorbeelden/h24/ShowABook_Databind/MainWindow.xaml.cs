using System.Windows;

namespace ShowABook_Databind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Book currentBook;

        public MainWindow()
        {
            InitializeComponent();
            currentBook = FindBook();
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = currentBook;
        }

        private Book FindBook()
        {
            return new Book()
            {
                ISBN = 9879043023421,
                Title = @"Programmeren in C#, tweede editie"
            };
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            // UI zal niet veranderen omdat currentBook geen event triggert
            currentBook.Title = "Programmeren in C#, vernieuwde derde editie";
        }
    }
}
