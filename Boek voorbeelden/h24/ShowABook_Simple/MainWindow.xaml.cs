using System.Windows;

namespace ShowABook_Simple
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
            isbnTextBlock.Text = $"{currentBook.ISBN}";
            titleTextBlock.Text = currentBook.Title;
        }

        private Book FindBook()
        {
            return new Book()
            {
                ISBN = 9879043023421,
                Title = @"Programmeren in C#, tweede editie"
            };
        }
    }
}
