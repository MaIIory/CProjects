using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a number. The number should be 
            between 1 to 10. If the user enters a valid number, display "Valid" on the console.
            Otherwise, display "Invalid". */

            Console.WriteLine("Hello User, please choose a number between 1 and 10:");
            int inputNumber = int.Parse(Console.ReadLine());
            if(inputNumber > 0 && inputNumber < 11)
            {
                Console.WriteLine("Valid\n");
            }
            else
            {
                Console.WriteLine("Invalid\n");
            }
        }
    }
}
