using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App27_IndexerMethods
{
    class Person
    {
        private string _name;
        private string _lastName;
        private int _employeeId;

        public Person(string name, string lastName, int id)
        {
            Name = name;
            LastName = lastName;
            _employeeId = id;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Id
        {
            get { return _employeeId; }
        }
    }
}
