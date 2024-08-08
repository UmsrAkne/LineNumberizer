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
                    Prefix = string.Empty,
                    PrefixNumber = 0,
                });
            }
        }

        public List<Line> DummyLines { get; private set; }
    }
}