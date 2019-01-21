using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_SumOfAllTypedNumbers
{
    class Program
    {
        

        static void Main(string[] args)
        {
            /*  Write a program and continuously ask the user to enter a number or "ok" to exit.
             *  Calculate the sum of all the previously entered numbers and display it on the console. */

            string inputString = String.Empty;
            int sum = 0;

            do
            {
                inputString = Console.ReadLine();

                int parseResult = 0;
                if (Int32.TryParse(inputString, out parseResult))
                    sum += parseResult;

            } while (inputString != "ok");

            Console.WriteLine(sum);
        }
    }
}
