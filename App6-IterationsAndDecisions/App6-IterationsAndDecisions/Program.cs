using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6_IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            FoorLoopExample();
            ForEachLoopExample();
            WhileLoopExample();
            DoWhileLoopExample();
            IfElseExample();
            SwitchExample();
            Console.ReadLine();
        }

        static void FoorLoopExample()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("i value: {0}",i);
            }
        }

        static void ForEachLoopExample()
        {

            //foreach loop works with all classes that implement IEnumerable interface
            string[] strArray = {"czesc", "hello", "god morgon" };
            foreach(string s in strArray)
                Console.WriteLine(s);

            int[] intArray = { 1, 4, 6, 34, 98 };
            foreach(int i in intArray)
                Console.WriteLine(i);
        }

        static void WhileLoopExample()
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("i: {0}", i++);
            }
        }

        static void DoWhileLoopExample()
        {
            int i = 20;

            do
            {
                i++;
                Console.WriteLine("Inside do/while loop, i: {0}",i);
            } while (i < 10);

            Console.WriteLine("Outside do/while loop, i: {0}", i);
        }

        static void IfElseExample()
        {
            //You can use only boolean in if conditions

            string myString = "my string";
            //if (myString.Length) { } -> ERROR - only booleans! 

            if (myString.Length > 0) { Console.WriteLine("myString is longer than 0"); }
        }

        static void SwitchExample()
        {
            Console.WriteLine("What is your age? ");
            Console.WriteLine("1: 0-20\n2: 20-40\n3: 40-60\n 4: 60-80");
            string userInput = Console.ReadLine();
            int parsedUserInput = int.Parse(userInput);

            switch(parsedUserInput)
            {
                case 1:
                    Console.WriteLine("Your are young!");
                    break;
                case 2:
                    Console.WriteLine("You are not so young!");
                    break;
                case 3:
                    Console.WriteLine("You are not so old!");
                    break;
                case 4:
                    Console.WriteLine("You are old!");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
