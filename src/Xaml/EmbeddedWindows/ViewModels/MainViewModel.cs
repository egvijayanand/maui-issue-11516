namespace EmbeddedWindows.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private int count = 0;
        private readonly ISemanticScreenReader _screenReader;

        public MainViewModel(ISemanticScreenReader screenReader)
        {
            Title = "Home";
            _screenReader = screenReader;
        }

        [ObservableProperty]
        private string _countText = "Current count: 0";

        [RelayCommand]
        private void Increment()
        {
            count++;
            CountText = $"Current count: {count}";
            _screenReader.Announce(CountText);
        }
    }
}
