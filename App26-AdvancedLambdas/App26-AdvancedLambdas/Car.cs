using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App26_AdvancedLambdas
{
    //class to store custom data
    //numbers of base class libraries use two arguments in delegates definitions:
    //painter to the caller and custom class with arguments, that inherits from EventArgs
    public class CarEventArgs : EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string message) { msg = message; }
    }

    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        //delegate definition may be associated with the class
        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        //The car can send these events
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        private bool carIsDead = false;

        public Car() { }

        public Car(string name, int maxSpeed, int currSpeed)
        {
            CurrentSpeed = currSpeed;
            MaxSpeed = maxSpeed;
            PetName = name;
        }

        //Method to invoke the delegate's invocation list under the correct circumstaces
        public void Accelerate(int delta)
        {

            if(carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry, car is dead"));
            }
            else
            {
                CurrentSpeed += delta;

                if (MaxSpeed - CurrentSpeed <= 0)
                {
                    carIsDead = true;
                }
                else if (MaxSpeed - CurrentSpeed <= 10)
                    AboutToBlow?.Invoke(this, new CarEventArgs("I am going to blow!"));
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
