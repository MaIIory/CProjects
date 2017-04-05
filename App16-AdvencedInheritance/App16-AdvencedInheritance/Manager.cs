using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16_AdvencedInheritance
{
    class Manager : Employee
    {
        //Compilation error - default ctor has been removed from Employee class
        //public Manager() { }

        public Manager(int ssn, string name, int id, float pay, int stockOptions) : this(ssn, name, id, pay, stockOptions, "", "", stockOptions) { }

        public Manager(int ssn, string name, int id, float pay, int age, string nickname, string password, int stockOptions) : base(ssn, name, id, pay, age, nickname, password)
        {
            StockOptions = stockOptions;
        }

        public int StockOptions { get; set; }
    }
}
