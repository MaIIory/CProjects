using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12_SimpleClass
{
    class Car
    {
        public string carName;
        public int currentSpeed;

        public Car() : this("Undefined name", 0)
        {
            Console.WriteLine("Inside constructor Car()");
        }

        public Car(string carName) : this(carName, 0)
        {
            Console.WriteLine("Inside constructor Car(name)");
        }

        public Car(int speed) : this("Undefined name", speed)
        {
            Console.WriteLine("Inside constructor Car(speed)");
        }

        //"Master" constructor
        public Car(string name, int speed)
        {
            Console.WriteLine("Inside constructor Car(name, speed)");

            if (speed > 100)
                speed = 100;

            carName = name;
            currentSpeed = speed;
        }

        public void SpeedUp(int delta)
        {
            currentSpeed += delta;
        }

        public void PrintState()
        {
            Console.WriteLine($"{carName} is going {currentSpeed} KM/H !!");
        }
    }
}
