using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21_GenericCollections
{
    class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Pay > y.Pay)
                return 1;
            else if (x.Pay < y.Pay)
                return -1;
            else return 0;
        }
    }
}
