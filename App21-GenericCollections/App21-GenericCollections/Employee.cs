using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21_GenericCollections
{
    class Employee
    {
        private string empName;
        private int empId;
        private float currPay;

        //autoamtic properties (fields are internally private, but they are not visible)
        public string Nickname { get; set; }
        public string Password { set { Console.WriteLine("Password set"); } }
        public int Age { get; set; }

        public Computer Hardware { get; set; }
        public Computer EmergencyHardware { get; set; } = new Computer();

        public Employee() : this("",0,0) { }

        public Employee(string name, int id, float pay)
        {
            Hardware = new Computer();
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
            Console.WriteLine("Employee's nickname: {0}", Nickname);
            Console.WriteLine("Emplyeee's age: {0}", Age);
            Console.WriteLine("Employee's hardware: {0}", Hardware.ToString());
        }

        public override string ToString()
        {
            return $"Name {empName}, id: {empId}, salary: {currPay}";
        }
    }
}
