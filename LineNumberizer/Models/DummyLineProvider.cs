using System.Collections.Generic;

namespace LineNumberizer.Models
{
    public class DummyLineProvider
    {
        public DummyLineProvider()
        {
            DummyLines = new List<Line>();

            for (var i = 0; i < 20; i++)
            {
                DummyLines.Add(new Line
                {
                    Text = $"ダミーのテキスト test test {i}",
                    FirstPrefix = string.Empty,
                    PrefixNumber = 0,
                    LineNumber = (i + 1).ToString(),
                });
            }
        }

        public List<Line> DummyLines { get; private set; }
    }
}