using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars10_ReversedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            String myString = ReverseWords("WFLFQAM ");
            Console.ReadLine();
        }

        public static string ReverseWords(string str)
        {
            String[] tmpString = str.Split(' ').Reverse().ToArray();
            return String.Join(" ", tmpString);
        }
    }
}
