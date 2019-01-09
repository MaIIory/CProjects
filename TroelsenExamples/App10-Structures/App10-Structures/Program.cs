using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10_Structures
{
    class Program
    {
        struct Point
        {
            public int X;
            public int Y;

            public Point (int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Increment()
            {
                X++;
                Y++;
            }

            public void Decrement()
            {
                X--;
                Y--;
            }

            public void Print()
            {
                Console.WriteLine($"X: {X}, Y: {Y}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** First look at structures ***");
            Point myPoint;
            myPoint.X = 340;
            myPoint.Y = 27;

            myPoint.Print();

            myPoint.Increment();
            myPoint.Print();

            myPoint.Decrement();
            myPoint.Print();

            Console.ReadLine();
        }
    }
}
