using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15_BasicInheritance
{
    class Car
    {
        private int currSpeed;

        public int MaxSpeed { get; set; }

        public int CurrSpeed
        {
            get
            {
                return currSpeed;
            }
            set
            {
                if (value > MaxSpeed)
                    currSpeed = MaxSpeed;
                else
                    currSpeed = value;
            }
        }

        public Car() : this(0, 100) { Console.WriteLine("Inside car default constructor"); }

        public Car(int currSpeed) : this(currSpeed, 100) { Console.WriteLine("Inside car constructor with currSpeed"); }

        public Car(int currSpeed, int maxSpeed)
        {
            Console.WriteLine("Inside master constructor");
            MaxSpeed = maxSpeed;
            CurrSpeed = currSpeed;
        }

        public void PrintStatus()
        {
            Console.WriteLine("This car is going {0} mph, while its maksimum speed is {1}", CurrSpeed, MaxSpeed);
        }

    }
}
