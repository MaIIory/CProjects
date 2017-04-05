using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17_Polymorphism
{
    class SalesPerson : Employee
    {
        //public SalesPerson(int ssn, string name, int id, float pay, int salesNumber) : this(ssn, name, id, pay, 0, "", "", salesNumber) { }

        public SalesPerson(int ssn, string name, int id, float pay, int salesNumber, int age = 0, string nickname = "", string password = "") : base(ssn, name, id, pay, age, nickname, password)
        {
            SalesNumber = salesNumber;
        }

        public int SalesNumber { get; set; }

        public override void GiveBonus(float bonus)
        {
            base.GiveBonus(bonus * SalesNumber);
        }

        public override void DisplayStatus()
        {
            Console.WriteLine("Employee sales number: {0}",SalesNumber);
        }

        public override void PrintEmployeeRole()
        {
            Console.WriteLine("Sales Person");
        }
    }
}
