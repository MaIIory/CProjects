using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Your job is to write a program for a speed camera. 
             * For simplicity, ignore the details such as camera, sensors, 
             * etc and focus purely on the logic. Write a program that asks 
             * the user to enter the speed limit. Once set, the program asks
             * for the speed of a car. If the user enters a value less than
             * the speed limit, program should display Ok on the console.
             * If the value is above the speed limit, the program should 
             * calculate the number of demerit points. For every 5km/hr above 
             * the speed limit, 1 demerit points should be incurred and displayed
             * on the console. If the number of demerit points is above 12, the
             * program should display License Suspended.*/

            Console.WriteLine("Hello User\nGive me the speed limit:");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, give me the current speed of a car:");
            int carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if ((carSpeed - speedLimit) > 12)
            {
                Console.WriteLine("License Suspended!");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine("You have got {0} number of demerit points!", demeritPoints);
            }
        }
    }
}
