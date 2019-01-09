using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_PascalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a few words separated by a space.
             * Use the words to create a variable name with PascalCase. For example, if the
             * user types: "number of students", display "NumberOfStudents". Make sure that
             * the program is not dependent on the input. So, if the user types
             * "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". */

            Console.WriteLine("Type few words separated by space:");
            var userInput = Console.ReadLine();

            var words = new List<string>();

            foreach(var elem in userInput.Split(' '))
            {
                words.Add(elem.ToLower());
            }

            for(int i = 0; i < words.Count; i++)
            {
                Console.Write(Convert.ToString(words[i][0]).ToUpper() + words[i].Substring(1));
            }
            Console.WriteLine();
        }
    }
}
