using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App34_CarLibrary;

namespace App35_CarLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniVan miniVanCar = new MiniVan("Trupek", 0, 100);
            SportCar sportCar = new SportCar("Szybcik", 0, 200);

            miniVanCar.TurboBoost();

            Console.ReadLine();

            sportCar.TurboBoost();

            Console.ReadLine();
            
        }
    }
}
