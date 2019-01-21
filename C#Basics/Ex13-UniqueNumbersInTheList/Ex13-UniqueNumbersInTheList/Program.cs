using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_UniqueNumbersInTheList
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to continuously enter a number or type "Quit" to exit.
             * The list of numbers may include duplicates. Display the unique numbers that the user
             * has entered. */

            var numbers = new List<int>();

            Console.WriteLine("Give me your numbers, type 'Quit' and click 'Enter' when you finish:");
            var input = Console.ReadLine();

            while (input != "Quit")
            {
                int inputNb = Int32.Parse(input);
                numbers.Add(inputNb);
                input = Console.ReadLine();
            }

            Console.WriteLine("Thank you, here is your unique numbers set:");
            var uniqueNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }

            foreach (var n in uniqueNumbers)
                Console.WriteLine(n);
        }
    }
}
