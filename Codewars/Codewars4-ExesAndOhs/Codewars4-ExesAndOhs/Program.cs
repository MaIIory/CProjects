using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars4_ExesAndOhs
{
    class Program
    {
        static void Main(string[] args)
        {
            XO("xox");
            XO("xoxSSS");
            XO("xox");
            XO("xoxxOO");

            Console.ReadLine();
        }

        public static bool XO(string input)
        {
            return input.Where(elem => elem == 'x' || elem == 'X').Count() == input.Where(elem => elem == 'o' || elem == 'O').Count();
        }
    }
}
