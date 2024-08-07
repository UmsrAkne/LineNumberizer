using Prism.Mvvm;

namespace LineNumberizer.ViewModels
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MainWindowViewModel : BindableBase
    {
        private string title;

        public string Title { get => title; set => SetProperty(ref title, value); }

        public MainWindowViewModel()
        {
        }
    }
}