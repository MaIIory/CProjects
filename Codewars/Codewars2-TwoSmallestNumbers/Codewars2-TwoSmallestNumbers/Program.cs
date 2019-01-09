using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars2_TwoSmallestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Console.WriteLine(sumTwoSmallestNumbers(numbers));
            Console.ReadLine();
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[0] + numbers[1];

        }
    }
}
