using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compilation Error - Employee is abstract class
            //Employee newEmp = new Employee(12345, 'Lukas', 123, 1500);

            Manager daniel = new Manager(12345, "Daniel", 123, 1900, 5);
            SalesPerson marcin = new SalesPerson(12346, "Marcin", 124, 1400, 8);

            Employee[] employeeSet = { daniel, marcin };

            foreach (Employee emp in employeeSet)
                emp.PrintEmployeeRole();

            //'as' keyword example
            Object[] myObjects = { daniel, marcin, 5 };

            foreach (object obj in myObjects)
            {
                Employee emp = obj as Employee;

                if (emp != null)
                    emp.PrintEmployeeRole();
            }

            //'is' keyword
            foreach (object obj in myObjects)
            {
                if (obj is Employee)
                    ((Employee)obj).PrintEmployeeRole();
            }


            Console.ReadLine();
        }
    }
}
