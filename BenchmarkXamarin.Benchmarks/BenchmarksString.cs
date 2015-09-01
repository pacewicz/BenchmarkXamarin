using System;

namespace BenchmarkXamarin.Sample
{
    class BenchmarksString
    {
        [Benchmark]
        public void Substring()
        {
            "musculus cremaster".Substring(8, 9);
        }

        [Benchmark]
        public void Split()
        {
            "  lingua latina non  verpa canina  ".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        [Benchmark]
        public void Trim()
        {
            "    lorem ipsum      ".Trim();
        }

        [Benchmark]
        public void StartWith()
        {
            "hello world, ребята".StartsWith("h");
        }
    }
}
