using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars12_ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "((Ale)ALE23[){}]())(";
            bool result = ValidParentheses(myString);
            Console.WriteLine("result: {0}",result);

            Console.ReadLine();
        }


        public static bool ValidParentheses(string input)
        {
            if (String.IsNullOrEmpty(input)) return true;

            //string onlyBrackets = String.Join("", (from elem in input where elem == '(' || elem == ')' select elem).ToArray<char>());
            string onlyBrackets = String.Join("", input.Where(i => i == '(' || i == ')').ToArray<char>());

            if (onlyBrackets.Length % 2 != 0) return false;

            while (onlyBrackets.Length > 0)
            {
                string replaceResult = onlyBrackets.Replace("()", "");
                if (replaceResult == onlyBrackets)
                    return false;
                onlyBrackets = replaceResult;
            }
            return true;
        }
    }
}
