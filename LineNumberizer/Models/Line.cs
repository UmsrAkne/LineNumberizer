using Prism.Mvvm;

namespace LineNumberizer.Models
{
    public class Line : BindableBase
    {
        private string text = string.Empty;
        private string prefix = string.Empty;
        private int prefixNumber;
        private string lineNumber = string.Empty;

        public string Text { get => text; set => SetProperty(ref text, value); }

        public string Prefix { get => prefix; set => SetProperty(ref prefix, value); }

        public int PrefixNumber { get => prefixNumber; set => SetProperty(ref prefixNumber, value); }

        public string LineNumber { get => lineNumber; set => SetProperty(ref lineNumber, value); }
    }
}