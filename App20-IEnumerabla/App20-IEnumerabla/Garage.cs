using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace App20_IEnumerable 
{
    class Garage : IEnumerable
    {
        Car[] carSet = new Car[5];

        public Garage()
        {

            carSet[0] = new Car("Maluch");
            carSet[1] = new Car("Polonez");
            carSet[2] = new Car("Warszawa");
            carSet[3] = new Car("Zlomek");
            carSet[4] = new Car("Zoltek");
        }


        //"Easiest" way to implement IEnumerable interface
        //Except usage of foreach instruction you can also
        //use IEnumerator methods
        public IEnumerator GetEnumerator()
        {
            return carSet.GetEnumerator();
        }


        //To hide interface implementation from object level we can use 
        //explicit interface implementation. In that case it won't be
        //accesable from user level but it may be handled by foreach logic
        /*
        IEnumerator IEnumerable.GetEnumerator()
        {
            return carSet.GetEnumerator();
        }
        */

        //Implementation with YIELD keyword
        /*
        public IEnumerator GetEnumerator()
        {
            foreach (Car car in carSet)
                yield return car;
        }
        */


    }
}
