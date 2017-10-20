using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars6_FindTheDivisors
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Divisors(12);

            foreach(int i in array)
                Console.WriteLine(i);
            Console.ReadLine();
        }

        public static int[] Divisors(int n)
        {
            List<int> result = new List<int>();

            for (int i = 2; true; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                    if ((n / i) != i)
                        result.Add(n / i);
                }
                if (n / i <= i) break;
            }

            result.Sort();

            if (result.Count() == 0)
                return null;

            return result.ToArray();
        }
    }
}
