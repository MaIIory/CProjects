using System;
<<<<<<< HEAD
=======
using System.Collections;
>>>>>>> Add SimpleDatabase app
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
<<<<<<< HEAD

            int[] array = Divisors(12);

            foreach(int i in array)
                Console.WriteLine(i);
=======
            Math.Sqrt(4);

            int[] array = Divisors(9);

            foreach (int i in array)
                Console.WriteLine(i);

>>>>>>> Add SimpleDatabase app
            Console.ReadLine();
        }

        public static int[] Divisors(int n)
        {
<<<<<<< HEAD
=======

            int loopCnt = 0;

            /*
            var result = new List<int>();

            for (int i = 2; i <= (int)Math.Sqrt(n); ++i)
            {

                loopCnt++;
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
            */


            //Solution 3

>>>>>>> Add SimpleDatabase app
            List<int> result = new List<int>();

            for (int i = 2; true; i++)
            {
<<<<<<< HEAD
                if (n % i == 0)
                {
                    result.Add(i);
                    if ((n / i) != i)
                        result.Add(n / i);
                }
                if (n / i <= i) break;
            }

=======
                //loopCnt++;
                if (n % i == 0)
                {
                    result.Add(i);

                    if ((n / i) != i)
                        result.Add(n / i);
                }

                if (n / i <= i) break;
            }

            //Console.WriteLine("loop counter is: " + loopCnt);

>>>>>>> Add SimpleDatabase app
            result.Sort();

            if (result.Count() == 0)
                return null;

            return result.ToArray();
<<<<<<< HEAD
        }
    }
}
=======


            //Solution 2
            /*
            List<int> divList = new List<int>();

            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    divList.Add(i);

            if (divList.Count == 0)
                return null;

            int[] result = new int[divList.Count];

            for(int i = 0; i < divList.Count; i++)
                result[i] = divList[i];

            return result;
            */

            //Solution 1
            //return Enumerable.Range(2, (n / 2) - 1).Where(elem => n % elem == 0).ToArray();
        }
    }
}

>>>>>>> Add SimpleDatabase app
