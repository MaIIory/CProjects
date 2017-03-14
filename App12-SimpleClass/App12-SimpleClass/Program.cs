using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12_SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Default Constructor
            Car myCar = new Car();
            myCar.PrintState();

            //Members set
            myCar.carName = "Zlomek";
            myCar.SpeedUp(10);
            myCar.PrintState();

            //Custom Constructor Car(name, speed)
            Car myCar2 = new Car("Mobilek", 110);
            myCar2.PrintState();

            //Order not relevant
            //Car myCar3 = new Car(60, "Spalinka"); - Does not compile

            //Second custom Constructor Car(name) (speed is thereby default)
            Car myCar4 = new Car("Zoltek");
            myCar4.PrintState();


            Console.ReadLine();
        }
    }
}
