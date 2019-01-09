using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen.
             * If the user simply presses Enter, without supplying an input, exit immediately;
             * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. */

            Console.WriteLine("Give sequence of numbers separated by hyphen:");
            var userInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userInput))
                return;

            var numbers = new List<int>();
            foreach (var num in userInput.Split('-'))
            {
                numbers.Add(Convert.ToInt32(num));
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                for(int j = 0; j < numbers.Count; j++)
                {
                    if((numbers[i] == numbers[j]) && (i != j))
                    {
                        Console.WriteLine("Duplicate");
                        return;
                    }
                }

            }
        }
    }
}
