using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_FiveNumbersInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to supply a list of comma separated numbers
             * (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers,
             * display "Invalid List" and ask the user to re-try; otherwise, display the 3
             * smallest numbers in the list. */

            Console.WriteLine("Give me 5 numbers separated by comma, e.x. 1,2,3,4,5 :");
            var input = Console.ReadLine();
            
            while(String.IsNullOrEmpty(input.Trim()))
            {
                Console.WriteLine("Invalid list, please try again.");
                input = Console.ReadLine();
            }

            var numbersArray = input.Split(',');

            while(numbersArray.Length < 5)
            {
                Console.WriteLine("Invalid list, please try again.");
                input = Console.ReadLine();
                numbersArray = input.Split(',');
            }

            var intNumbersArray = new int[5];

            for(int i = 0; i < 5; i++)
            {
                intNumbersArray[i] = Int32.Parse(numbersArray[i]);
            }

            Array.Sort(intNumbersArray);

            Console.WriteLine("Here are 3 smallest numbers:");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(intNumbersArray[i]);
        }
    }
}
