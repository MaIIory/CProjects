using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars3_ArrayComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };

            Console.WriteLine(comp(a,b));
            Console.ReadLine();
        }

        public static bool comp(int[] a, int[] b)
        {
            if ((a == null || b == null) || (a.Length != b.Length))
                return false;

            Array.Sort(a);
            Array.Sort(b);

            for(int i = 0; i < a.Length; i++)
                if (b[i] != a[i] * a[i])
                    return false;

            return true;
        }
    }
}
