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
            int n = 4;

            var res = Divisors(n);

            if (res != null)
                foreach (var e in res)
                    Console.WriteLine(e);
            
            Console.ReadLine();
        }

        public static int[] Divisors(int n)
        {

            List<int> result = new List<int>();

            for (int i = 2; Math.Pow(i,2) <= n; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);

                    if ((n / i) != i)
                        result.Add(n / i);
                }
            }

            result.Sort();

            if (result.Count() == 0)
                return null;

            return result.ToArray();
        }
    }
}
