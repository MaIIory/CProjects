using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter 5 numbers. If a number has been
             * previously entered, display an error message and ask the user to re-try.
             * Once the user successfully enters 5 unique numbers, sort them and display
             * the result on the console. */

            var numbers = new List<int>();
            Console.WriteLine("Specify 5 different numbers.");

            while(numbers.Count < 5)
            {
                Console.WriteLine("Give me the next number:");
                int number = Int32.Parse(Console.ReadLine());

                if(numbers.IndexOf(number) == -1) //not found
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("The number you have provided already exist, please try again.");
                }
            }

            numbers.Sort();
            Console.WriteLine("Here is your number set:");
            foreach(var n in numbers)
                Console.WriteLine(n);
        }
    }
}
