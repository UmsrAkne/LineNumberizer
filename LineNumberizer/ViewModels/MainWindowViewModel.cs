using System.Collections.ObjectModel;
using LineNumberizer.Models;
using Prism.Mvvm;

namespace LineNumberizer.ViewModels
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MainWindowViewModel : BindableBase
    {
        private string title;

        public MainWindowViewModel()
        {
        }

        public string Title { get => title; set => SetProperty(ref title, value); }

        public ObservableCollection<Line> Lines { get; set; } = new ();
    }
}