using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App23_AdvancedDelegates
{
    //Definition of delegate type
    //The delegate may point to any method taking a single string as an input and void as a return value
    delegate void CarEngineHandler(string msgForCaller);

    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        //Optionally, delegate definition may associated with the class
        //public delegate void CarEngineHandler(string msgForCaller);

        //Member variable of the delegate - it holds delegate list of handlers - it's type is MultiCastDelegate
        private CarEngineHandler listOfHandlers;

        private bool carIsDead = false;

        public Car() { }

        public Car(string name, int maxSpeed, int currSpeed)
        {
            CurrentSpeed = currSpeed;
            MaxSpeed = maxSpeed;
            PetName = name;
        }

        //Registration function for the caller
        //Note: We keep delegete member private and we have encapsulated method to 
        //register methods to avoid external manipulation of delegate member.
        //If it would be public the list of the method could be easily changed
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            if (listOfHandlers == null)
                listOfHandlers = methodToCall;
            else
                listOfHandlers += methodToCall;
        }

        //Method to invoke the delegate's invocation list under the correct circumstaces
        public void Accelerate(int delta)
        {

            if(carIsDead)
            {
                listOfHandlers?.Invoke("Sorry, car is dead");
            }
            else
            {
                CurrentSpeed += delta;

                if (MaxSpeed - CurrentSpeed <= 0)
                {
                    listOfHandlers?.Invoke("Ok, I am done :(");
                    carIsDead = true;
                }
                else if (MaxSpeed - CurrentSpeed <= 10)
                    listOfHandlers?.Invoke("Engine is about to blow");
                else
                {
                    string msg = "OK, current speed is " + CurrentSpeed.ToString();
                    listOfHandlers?.Invoke(msg);
                }
            }
        }

        private void checkPrivateMethod(string msg)
        {
            Console.WriteLine("This message should not accure: {0}", msg);
        }

    }
}
