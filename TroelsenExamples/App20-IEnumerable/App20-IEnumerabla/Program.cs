using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App20_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage garage = new Garage();


            foreach(Car car in garage)
            {
                Console.WriteLine("Car name: {0}", car.carName);
            }

            Console.WriteLine("Let's try advenced garage!!!");

            AdvencedGarage advGarage = new AdvencedGarage();

            foreach(Car car in advGarage)
                Console.WriteLine("Advenced car: {0}",car.carName);


            Console.ReadLine();
        }
    }
}
