using System.ComponentModel;

namespace ShowABook_PropChanged
{
    public class Book : INotifyPropertyChanged
    {
        public long ISBN { get; set; }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
