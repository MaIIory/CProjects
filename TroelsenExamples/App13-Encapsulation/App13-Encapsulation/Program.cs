using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Handling getters and setters in 'old' manner
            Employee newEmp = new Employee("Lukasz", 12, 1200);
            newEmp.GiveBonus(1000);
            newEmp.DisplayStatus();
            newEmp.SetName("Lucyn");
            newEmp.SetName("The new name exceeds 15 characters :) ");
            Console.WriteLine("new employee name: {0}", newEmp.GetName());

            //Handling getters and setters in .NET properties manner
            newEmp.Id = 200;
            newEmp.Id = 99;
            Console.WriteLine("new employee id is: {0}",newEmp.Id);

            newEmp.Pay += 500;

            newEmp.DisplayStatus();

            Employee newEmp2 = new Employee();

            newEmp2.DisplayStatus();

            Console.ReadLine();
        }
    }
}
