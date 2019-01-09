using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15_BasicInheritance
{
    class MiniVan : Car
    {
        public MiniVan()
        {
            Console.WriteLine("Inside MiniVan constructor");
            MaxSpeed = 90;
        }
    }
}
