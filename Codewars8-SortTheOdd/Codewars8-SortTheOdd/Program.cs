using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Codewars8_SortTheOdd
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 3, 2, 8, 5, 4 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i].ToString() + ' ');
            }
            Console.WriteLine();

            a = SortArray(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i].ToString() + ' ');
            }


            Console.ReadLine();
        }

        public static int[] SortArray(int[] array)
        {
            if (array.Length <= 0)
                return array;

            Stack<int> oddStack = new Stack<int>();
            foreach (int nb in from elem in array where elem % 2 != 0 orderby elem descending select elem)
                oddStack.Push(nb);

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0) array[i] = oddStack.Pop();

            return array;
        }
    }
}
