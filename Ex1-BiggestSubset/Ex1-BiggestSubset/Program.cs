using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_BiggestSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputSet = { -100,-4,-1,0 };

            object[] biggestSubset = new object[inputSet.Length - 1];
            int currentIndex = 0;
            object[] twoBiggestNumbers = { inputSet[0], inputSet[1] };

            if(inputSet[1] > inputSet[0])
            {
                twoBiggestNumbers[0] = inputSet[1];
                twoBiggestNumbers[1] = inputSet[0];
            }
            
            for(int i = 0; i < inputSet.Length; i++)
            {
                if (inputSet[i] > 0)
                {
                    biggestSubset[currentIndex] = inputSet[i];
                    currentIndex++;
                }

                if (inputSet[i] > (int)twoBiggestNumbers[0])
                {
                    twoBiggestNumbers[1] = twoBiggestNumbers[0];
                    twoBiggestNumbers[0] = inputSet[i];
                }
                else if (inputSet[i] > (int)twoBiggestNumbers[1])
                    twoBiggestNumbers[i] = inputSet[i];
            }

            Console.WriteLine("Biggest subset is:");
            if (currentIndex > 1)
            {
                for (int i = 0; i < biggestSubset.Length; i++)
                {
                    if (biggestSubset[i] == null)
                        break;
                    else
                        Console.WriteLine((int)biggestSubset[i]);
                }

            }
            else
            {
                foreach (int i in twoBiggestNumbers)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
            return;

        }
    }
}
