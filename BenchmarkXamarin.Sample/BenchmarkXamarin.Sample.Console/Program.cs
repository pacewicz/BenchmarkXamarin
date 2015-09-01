using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BenchmarkXamarin.Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkManager manager = BenchmarkManager.Current;
            manager.Log += WriteLine;
            manager.Register(typeof(BenchmarksBasic).Assembly);
            manager.Start();

            ReadLine();
        }
    }
}
