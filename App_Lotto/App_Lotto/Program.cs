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




            Console.ReadLine();

        }
    }
}
