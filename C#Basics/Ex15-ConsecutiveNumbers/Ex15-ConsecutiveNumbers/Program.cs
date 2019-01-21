using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_ConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen.
             * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9"
             * or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive". */

            Console.WriteLine("Give sequence of numbers separated by hyphen:");
            var userInput = Console.ReadLine();

            var numbers = new List<int>();
            foreach(var num in userInput.Split('-'))
            {
                numbers.Add(Convert.ToInt32(num));
            }

            for(int i = 1; i < numbers.Count;i++)
            {
                if (Math.Abs(numbers[i] - numbers[i - 1]) == 1)
                    continue;
                else
                {
                    Console.WriteLine("Not consecutive");
                    return;
                }
            }
            Console.WriteLine("Consecutive");
        }
    }
}
