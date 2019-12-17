using BookstoreApp.Models;
using System.Windows;
using System.Windows.Controls;

namespace BookstoreApp.Views
{
    public enum FormsMode
    {
        View,
        Edit
    }

    /// <summary>
    /// Interaction logic for BookStoreWindow.xaml
    /// </summary>
    public partial class BookStoreWindow : Window
    {
        private BookStore bookStore;
        private Book currentBookBackup;
        private FormsMode currentMode;

        public BookStoreWindow()
        {
            InitializeComponent();

            bookStore = new BookStore();
            booksListView.ItemsSource = bookStore.GetAllBooks();

            booksListView.SelectedIndex = 0;
            this.DataContext = booksListView.SelectedItem;

            SwitchMode(FormsMode.View);
        }

        private void booksListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DataContext = booksListView.SelectedItem;
        }

        private void SwitchMode(FormsMode mode)
        {
            currentMode = mode;
            switch (mode)
            {
                case FormsMode.View:
                    cancelButton.Visibility = Visibility.Hidden;
                    editSaveButton.Content = "Bewerk";
                    titleTextBox.IsEnabled = false;
                    break;
                case FormsMode.Edit:
                    editSaveButton.Content = "Bewaar";
                    cancelButton.Visibility = Visibility.Visible;
                    titleTextBox.IsEnabled = true;
                    break;
                default:
                    break;
            }
        }

        private void editSaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentMode == FormsMode.View)
            {
                SwitchMode(FormsMode.Edit);
                Book selectedBook = (Book)booksListView.SelectedItem;
                currentBookBackup = new Book()
                {
                    Title = selectedBook.Title,
                };
            }
            else
            {
                SwitchMode(FormsMode.View);
                currentBookBackup = null;
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            //restore old values
            Book editedBook = (Book)booksListView.SelectedItem;
            editedBook.Title = currentBookBackup.Title;
            SwitchMode(FormsMode.View);
            currentBookBackup = null;
        }
    }
}
