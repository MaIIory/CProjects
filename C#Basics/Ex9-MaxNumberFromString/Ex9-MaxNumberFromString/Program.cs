using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_MaxNumberFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a series of numbers separated by comma.
             * Find the maximum of the numbers and display it on the console. For example,
             * if the user enters “5, 3, 8, 1, 4", the program should display 8. */

            Console.WriteLine("Give me number series separated by comma:");
            string[] numbers = Console.ReadLine().Split(',');

            int maks = Int32.Parse(numbers[0]);

            foreach(string s in numbers)
            {
                if (Int32.Parse(s) > maks)
                    maks = Int32.Parse(s);
            }

            Console.WriteLine("Biggest number is: {0}",maks);
        }
    }
}
