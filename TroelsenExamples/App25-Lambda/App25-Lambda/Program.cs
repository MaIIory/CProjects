using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App25_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make list of integers
            List<int> list = new List<int>();

            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //Now, use a C# lambda expression 
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

            Console.WriteLine("Here are your even numbers:");
            foreach (int i in evenNumbers)
                Console.Write(i + ", ");
            Console.WriteLine("\n");

            //Here is more advenced approach
            List<int> list2 = new List<int>();

            list2.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 14 });

            List<int> evenNumbers2 = list2.FindAll(i =>
           {
               Console.WriteLine("i: {0}",i);
               bool isEven = ((i % 2) == 0);
               return isEven; 
           });

            Console.WriteLine("Here are your even numbers:");
            foreach (int i in evenNumbers2)
                Console.Write(i + ", ");
            Console.WriteLine("\n");



            Console.ReadLine();
        }
    }
}
