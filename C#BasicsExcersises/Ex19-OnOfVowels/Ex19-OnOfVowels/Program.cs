using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_OnOfVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter an English word. Count the number of vowels
             * (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should
             * display 6 on the console. */

            Console.WriteLine("Type custom english word:");
            var userInput = Console.ReadLine();
            int vowelsCounter = 0;
            char[] vowelsSet = { 'a','A', 'e','E', 'o','O', 'u','U', 'i', 'I' };


            foreach(char c in userInput)
                foreach (char vow in vowelsSet)
                    if (c == vow)
                        vowelsCounter++;

            Console.WriteLine("Nb of vowels: {0}", vowelsCounter);
        }
    }
}
