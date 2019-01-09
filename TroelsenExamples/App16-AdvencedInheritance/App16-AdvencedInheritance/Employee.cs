using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16_AdvencedInheritance
{
    class Employee
    {
        //getter and setter are implemented in 'classic' manner
        private string empName;

        //getter and setter are implemented in 'properties' manner
        private int empId;
        private float currPay;

        //automatic properties (fields are internally private, but they are not visible)
        public int Age { get; set; }
        public string Nickname { get; set; }
        public string Password { set { Console.WriteLine("Password set"); } }
        
        //read only property (security number)
        private int ssn;
        public int SSN { get { return ssn; } }

        //Example of HAS-A relationship
        public Computer Hardware { get; set; }
        public Computer EmergencyHardware { get; set; } = new Computer();

        //no default constructor - we are sure basic data will be filled
        //public Employee() : this(0,"",0,0) { }

        public Employee(int ssn, string name, int id, float pay) : this(ssn, name, id,pay,0,"","") { }

        public Employee(int ssn, string name, int id, float pay, int age, string nickname, string password)
        {
            Hardware = new Computer();
            this.ssn = ssn;
            empName = name;
            empId = id;
            currPay = pay;
            Age = age;
            Nickname = nickname;
            Password = password;
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
            Console.WriteLine();
        }
    }
}
