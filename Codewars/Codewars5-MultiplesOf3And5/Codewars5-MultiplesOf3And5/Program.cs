using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars5_MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
            Console.ReadLine();
        }

        public static int Solution(int value)
        {
            return Enumerable.Range(0, value).Where(elem => elem % 3 == 0 || elem % 5 == 0).Sum();
        }
    }
}
