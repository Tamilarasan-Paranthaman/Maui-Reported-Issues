using System.ComponentModel;
using System.Windows.Input;

namespace SearchHandlerClearPlaceholderIcon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new SearchViewModel();
        }
    }

    public class SearchViewModel : INotifyPropertyChanged
    {
        private string _searchPlaceholder = "Type a player's name to search";

        public string SearchPlaceholder
        {
            get => _searchPlaceholder;
            set
            {
                if (_searchPlaceholder != value)
                {
                    _searchPlaceholder = value;
                    OnPropertyChanged(nameof(SearchPlaceholder));
                }
            }
        }

        public ICommand ClearPlaceholderCommand { get; }

        public SearchViewModel()
        {
            ClearPlaceholderCommand = new Command(() =>
            {
                SearchPlaceholder = string.Empty;
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
