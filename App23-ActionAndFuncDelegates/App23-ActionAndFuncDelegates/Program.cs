using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App23_ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            //ACTION delegate example
            Action<string, ConsoleColor, int> myAction = new Action<string, ConsoleColor, int>(DisplayMessage);
            myAction("Action message", ConsoleColor.Yellow, 5);

            //FUNC delegate example (last argument is the return value)
            Func < int, int, int> addFunc = new Func<int, int, int>(Add);
            Console.WriteLine(addFunc(2, 4));

            //example 2
            Func<int, int, string> sumToStringFunc = new Func<int, int, string>(SumToString);
            Console.WriteLine(sumToStringFunc(2,4));

            sumToStringFunc.Invoke(2,7);

            //You can use group conversion syntax
            Func<int, int, string> sumToStringFunc2 = SumToString;

            Console.ReadLine();
        }

        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor prev = Console.ForegroundColor;

            Console.ForegroundColor = txtColor;

            for(int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = prev;
        }

        static int Add (int x, int y)
        {
            return x + y;
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
