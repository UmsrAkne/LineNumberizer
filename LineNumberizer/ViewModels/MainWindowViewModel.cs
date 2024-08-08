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
            Lines = new ObservableCollection<Line>(new DummyLineProvider().DummyLines);
        }

        public string Title { get => title; set => SetProperty(ref title, value); }

        public ObservableCollection<Line> Lines { get; set; } = new ();
    }
}