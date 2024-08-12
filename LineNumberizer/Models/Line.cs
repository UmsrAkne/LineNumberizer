using Prism.Mvvm;

namespace LineNumberizer.Models
{
    public class Line : BindableBase
    {
        private string text = string.Empty;
        private string firstPrefix = string.Empty;
        private int prefixNumber;
        private string lineNumber = string.Empty;
        private string secondPrefix;

        public string Text { get => text; set => SetProperty(ref text, value); }

        public string FirstPrefix { get => firstPrefix; set => SetProperty(ref firstPrefix, value); }

        public string SecondPrefix { get => secondPrefix; set => SetProperty(ref secondPrefix, value); }

        public int PrefixNumber { get => prefixNumber; set => SetProperty(ref prefixNumber, value); }

        public string LineNumber { get => lineNumber; set => SetProperty(ref lineNumber, value); }
    }
}