using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App27_IndexerMethods
{
    class PersonCollection
    {
        private ArrayList peopleArray = new ArrayList();


        //Different methods to implement indexer mechanism
        public Person this[int index]
        {
            get { return (Person)peopleArray[index]; }
            set { peopleArray.Insert(index, value); }
        }

    }
}
