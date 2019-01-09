using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App24_Events
{

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zoltek", 120, 10);

            //method group conversion
            myCar.AboutToBlow += MyCar_AboutToBlow;
            myCar.AboutToBlow += MyCar_AboutToBlow1;

            myCar.Exploded += MyCar_Exploded;

            //Example of anonymous methods
            myCar.Exploded += delegate (string msg) { Console.WriteLine("I Exploded : {0}",msg); };
            myCar.Exploded += delegate { Console.WriteLine("I am dead"); };

            for (int i = 0; i < 10; i++)
                myCar.Accelerate(20);

            //Error: Event can't be invoked externally
            //myCar.Exploded.Invoke();

            Console.ReadLine();
        }

        private static void MyCar_Exploded(string msg)
        {
            Console.WriteLine("OK I am done :(");
        }

        private static void MyCar_AboutToBlow1(string msg)
        {
            Console.WriteLine("Easy buddy");
        }

        private static void MyCar_AboutToBlow(string msg)
        {
            Console.WriteLine("I am going to blow!!!");
        }
    }
}
