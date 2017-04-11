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

            if(currentSpeed > maxSpeed)
            {
                //In case max speed is excedeed, throw new execption
                currentSpeed = 0;
                isDead = true;
                string exceptionMsg = "The car has just blown up";
                Exception carException = new Exception(exceptionMsg);
                carException.Data.Add(0, "Car has been damaged permanently");

                throw carException;
            }

        }
    }
}
