using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_NumberComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Hello User, type two numbers to compare in the following format: n1, n2");

            string inputString = Console.ReadLine();

            string[] numbers = inputString.Split(',');

            Console.WriteLine("Max is:");
            if(int.Parse(numbers[0]) > int.Parse(numbers[1]))
                Console.WriteLine(numbers[0]);
            else
                Console.WriteLine(numbers[1]);
        }
    }
}
