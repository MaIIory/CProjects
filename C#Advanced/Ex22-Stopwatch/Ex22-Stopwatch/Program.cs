using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var input = Console.ReadLine();
            while(input != "Quit")
            {

                if(input == "Start")
                {
                    stopwatch.Start();
                }
                else if (input == "Stop")
                {
                    stopwatch.Stop();
                }
                input = Console.ReadLine();
            }
        }
    }
}
