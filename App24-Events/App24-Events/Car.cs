using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App24_Events
{

    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        //delegate definition may associated with the class
        public delegate void CarEngineHandler(string msg);

        //The car can send these events
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        //Member variable of the delegate - it holds delegate list of handlers - it's type is MultiCastDelegate
        //private CarEngineHandler listOfHandlers;

        private bool carIsDead = false;

        public Car() { }

        public Car(string name, int maxSpeed, int currSpeed)
        {
            CurrentSpeed = currSpeed;
            MaxSpeed = maxSpeed;
            PetName = name;
        }

        //Registration function for the caller
        /*
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            if (listOfHandlers == null)
                listOfHandlers = methodToCall;
            else
                listOfHandlers += methodToCall;
        }
        */

        //Method to invoke the delegate's invocation list under the correct circumstaces
        public void Accelerate(int delta)
        {

            if(carIsDead)
            {
                Exploded?.Invoke("Sorry, car is dead");
            }
            else
            {
                CurrentSpeed += delta;

                if (MaxSpeed - CurrentSpeed <= 0)
                {
                    carIsDead = true;
                }
                else if (MaxSpeed - CurrentSpeed <= 10)
                    AboutToBlow?.Invoke("I am going to blow!");
                else
                {
                    string msg = "OK, current speed is " + CurrentSpeed.ToString();
                    Console.WriteLine(msg);
                }
            }
        }

        private void checkPrivateMethod(string msg)
        {
            Console.WriteLine("This message should not accure: {0}", msg);
        }

    }
}
