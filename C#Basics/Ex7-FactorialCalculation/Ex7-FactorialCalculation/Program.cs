using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_FactorialCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a number.
             * Compute the factorial of the number and print it on the console.
             * For example, if the user enters 5, the program should calculate 
             * 5 x 4 x 3 x 2 x 1 and display it as 5! = 120. */

            var number = Int32.Parse(Console.ReadLine());
            var result = number;

            for(int i = number - 1; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine("{0}! = {1}",number,result);
        }
    }
}
