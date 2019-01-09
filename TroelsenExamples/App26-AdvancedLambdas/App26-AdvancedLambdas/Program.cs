using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App26_AdvancedLambdas
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

            //Example of anonymous function
            myCar.Exploded += (sender, msg) => Console.WriteLine("Message from {0} is: {1}",((Car)sender).PetName,msg);
            myCar.Exploded += (sender, msg) => Console.WriteLine("I am dead");

            for (int i = 0; i < 10; i++)
                myCar.Accelerate(20);

            //Error: Event can't be invoked externally
            //myCar.Exploded.Invoke();

            Console.ReadLine();
        }

        //Single Statement Member Implementations
        private static void MyCar_Exploded(object sender, CarEventArgs args) => Console.WriteLine("OK I am done :(");

        private static void MyCar_AboutToBlow1(object sender, CarEventArgs args) => Console.WriteLine("Easy buddy");

        private static void MyCar_AboutToBlow(object sender, CarEventArgs args) => Console.WriteLine("I am going to blow!!!");
    }
}
