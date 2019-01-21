using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_LongestWordInAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the longest word in the file.
            var content = File.ReadAllText(string.Format(@"{0}\Data\Words.txt",Directory.GetCurrentDirectory()));
            var longestWord = string.Empty;

            foreach(var line in content.Split('\n'))
            {
                foreach(var word in line.Split(' '))
                {
                    if (word.Length > longestWord.Length)
                        longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
