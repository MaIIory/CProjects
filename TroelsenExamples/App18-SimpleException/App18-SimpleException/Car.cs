using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18_SimpleException
{
    class Car
    {
        public bool isDead = false;
        public int maxSpeed = 100;
        public int currentSpeed = 0;

        public void Accelerate(int speed)
        {
            currentSpeed += speed;
            Console.WriteLine("Accelerating to {0}",currentSpeed);

            if(speed <= 0)
            {
                //create and throw default exception
                Exception speedIsTooLowException = new Exception("Speed must be greaten than 0");
                throw speedIsTooLowException;

            }

            if(currentSpeed > maxSpeed)
            {
                //In case max speed is excedeed, throw new exception
                currentSpeed = 0;
                isDead = true;
                string exceptionMsg = "The car has just blown up";

                //Create and throw custom exception
                CarExplodedException carException = new CarExplodedException(exceptionMsg);
                carException.Data.Add(0, "Car has been damaged permanently");

                throw carException;
            }

        }
    }
}
