using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15_BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Construct parentCar...");
            Car parentCar = new Car();
            parentCar.PrintStatus();

            parentCar.MaxSpeed = 80;
            parentCar.CurrSpeed = 20;
            parentCar.PrintStatus();

            parentCar.CurrSpeed = 100;
            parentCar.PrintStatus();

            Console.WriteLine("Construct myVan...");
            //Constructors are not inherited, so we can use only default version. 
            //However the chain of ctors are called
            MiniVan myVan = new MiniVan();
            myVan.PrintStatus();

            //myVan.currSpeed = 20; -> compiler error: you can't access private member
            myVan.CurrSpeed = 20;
            myVan.PrintStatus();


            Console.ReadLine();
        }
    }
}
