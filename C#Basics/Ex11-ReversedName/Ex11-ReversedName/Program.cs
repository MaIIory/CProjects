using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_ReversedName
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter their name. Use an array to reverse
             * the name and then store the result in a new string. Display the reversed name
             * on the console. */

            Console.WriteLine("Give me your name, please:");
            var name = Console.ReadLine().ToArray<char>();
            Array.Reverse(name);

            var reversedName = "";
            foreach (char c in name)
                reversedName += c;

            Console.WriteLine("Your reversed name is {0}",reversedName);
        }
    }
}
