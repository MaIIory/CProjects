using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_NbOfWordsInAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the number of words.
            string path = string.Format(@"{0}\Data\",Directory.GetCurrentDirectory());

            var content = File.ReadAllText(Directory.GetFiles(path)[0]);

            int wordsCounter = 0;
            foreach (var word in content.Split('\n'))
                wordsCounter += word.Split(' ').Length;

            Console.WriteLine(wordsCounter);
        }
    }
}
