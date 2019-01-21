using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App20_IEnumerable
{
    class AdvencedGarage : IEnumerable
    {

        Car[] carSet = new Car[5];

        public AdvencedGarage()
        {
            carSet[0] = new Car("Maluch");
            carSet[1] = new Car("Polonez");
            carSet[2] = new Car("Warszawa");
            carSet[3] = new Car("Zlomek");
            carSet[4] = new Car("Zoltek");
        }

        public IEnumerator GetEnumerator()
        {
            return new AdvencedGarageEnumerator(carSet);
        }
    }

    class AdvencedGarageEnumerator : IEnumerator
    {
        Car[] carSet;
        int index = -1;

        public AdvencedGarageEnumerator(Car[] carSet)
        {
            this.carSet = carSet;
        }

        public object Current
        {
            get
            {
                return carSet[index];
            }
        }

        public bool MoveNext()
        {
            if (index + 1 >= carSet.Length)
                return false;
            else
                index++;

            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }

}
