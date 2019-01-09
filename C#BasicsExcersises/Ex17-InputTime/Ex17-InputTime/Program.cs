using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_InputTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a time value in the 24-hour time format
             * (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid,
             * display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any
             * values, consider it as invalid time. */

            Console.WriteLine("Type a time in 24 hour format, e.x. 19:23");

            var userInput = Console.ReadLine();

            try
            {
                var date = Convert.ToDateTime(userInput);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
