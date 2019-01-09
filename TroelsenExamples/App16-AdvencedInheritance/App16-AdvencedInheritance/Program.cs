using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16_AdvencedInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmp = new Employee(12345, "Lukas", 123, 1500, 24, "Lucyn", "Pass123");
            newEmp.DisplayStatus();


            //Manager newMan = new Manager();
            //newMan.DisplayStatus();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
