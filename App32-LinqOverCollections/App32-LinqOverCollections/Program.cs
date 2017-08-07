using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App32_LinqOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>(){
                new Car { PetName = "Henry", Color = "Silver", Make = "VW", Speed = 100 },
                new Car { PetName = "Johny", Color = "Yellow", Make = "Fiat", Speed = 80 },
                new Car { PetName = "Bravo", Color="Black", Make="BMW", Speed = 120 },
                new Car { PetName = "Grease", Color = "Golden", Make="Citroen", Speed=75},
                new Car { PetName = "Ocean", Color = "Blue", Make = "BMW", Speed=92 } 
            };

            var fastBMWs = from car in myCars where car.Speed > 90 && car.Make == "BMW" select car;

            foreach (Car car in fastBMWs)
                Console.WriteLine(car.PetName);

            Console.ReadLine();
        }
    }
}
