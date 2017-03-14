using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13_Encapsulation
{
    class Employee
    {
        private string empName;
        private int empId;
        private float currPay;

        public Employee() { }

        public Employee(string name, int id, float pay)
        {
            empName = name;
            empId = id;
            currPay = pay;
        }

        public void GiveBonus(float bonus)
        {
            currPay += bonus;
        }

        //Legacy SET implementation
        public void SetName(string name)
        {
            if (name.Length >= 15)
            {
                Console.WriteLine("Typed name too long. Name has not been changed!");
            }
            else
            {
                Console.WriteLine("New name is: {0}", name);
                empName = name;
            }
            return;
        }

        //Legacy GET implementation
        public string GetName()
        {
            return empName;
        }

        //GET and SET implementation compliant with .NET properties
        public int Id
        {
            get { return empId; }
            set
            {
                if (value > 100)
                    Console.WriteLine("Number of employees exceded 100!");
                else
                    empId = value;
            }
        }

        //GET and SET implementation compliant with .NET properties
        public float Pay
        {
            get { return currPay; }
            set
            {
                if (value < 1200)
                    Console.WriteLine("Employee can't earn less than 1200!");
                else
                    currPay = value;
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Employee name: {0}", empName);
            Console.WriteLine("Employee id:   {0}", empId);
            Console.WriteLine("Employee salary: {0}", currPay);
        }
    }
}
