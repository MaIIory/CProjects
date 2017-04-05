using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16_AdvencedInheritance
{
    class SalesPerson : Employee
    {
        //public SalesPerson(int ssn, string name, int id, float pay, int salesNumber) : this(ssn, name, id, pay, 0, "", "", salesNumber) { }

        public SalesPerson(int ssn, string name, int id, float pay, int salesNumber, int age = 0, string nickname = "", string password = "") : base(ssn, name, id, pay, age, nickname, password)
        {
            SalesNumber = salesNumber;
        }

        public int SalesNumber { get; set; }
    }
}
