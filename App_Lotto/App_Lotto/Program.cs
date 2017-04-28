using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Wrong number of arguments");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"I will look for most common sequence of {args[0]} numbers in Lotto history!");

            //TODO Implement test timers that will be used
            //to measure performence of specific step 

            //TODO Load results from file

            //TODO For every daily result calculate specified sequence of numbers 
               //TODO For every sequence convert it to key
               //TODO check if that entry exist in dictionary
                  //TODO if 'yes' step counter in this sequence
                  //TODO if 'not' create new class wiht specific sequence

            Console.ReadLine();

        }

        public int ConvertSequenceToKey()
        {
            //Converts sequences to key e.g.:
            //1,3,6,13,24,36,48 -> 01030613243648
            //after conversion key may serve as dictionary key 

            return 0;
        }
    }
}
