using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11_ValueAndReferenceType
{
    class Program
    {
        struct Point
        {
            public int X;
            public int Y;

            public PointRef point;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
                point = new PointRef(x, y);
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
                Console.WriteLine($"X: {X}, Y: {Y}, point.X: {point.X}, point.Y: {point.Y}");
            }
        }

        class PointRef
        {
            public int X;
            public int Y;

            public PointRef(int x, int y)
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

            Console.WriteLine("Assigning value types");
            Point p1 = new Point(10, 10);
            Point p2 = p1;

            p1.Print();
            p2.Print();

            p1.X = 20;

            p1.Print();
            p2.Print();

            Console.WriteLine("Assigning reference type");
            PointRef p3 = new PointRef(10, 10);
            PointRef p4 = p3;

            p3.Print();
            p4.Print();

            p3.X = 20;

            p3.Print();
            p4.Print();

            Console.WriteLine("Shallow copy of value type");
            p2 = p1;
            p1.point.X = 55;

            p1.Print();
            p2.Print();

            Console.ReadLine();
        }
    }
}
