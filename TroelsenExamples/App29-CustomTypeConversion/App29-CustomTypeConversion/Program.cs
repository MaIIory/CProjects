using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App29_CustomTypeConversion
{
    class Program
    {

        struct Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle(int w, int h) : this()
            {
                Width = w;
                Height = h;
            }

            //Squares can be implicitly converted into Rectangles
            public static implicit operator Rectangle(Square s)
            {
                Rectangle r = new Rectangle(s.Length, s.Length);
                return r;
            }
        }

        struct Square
        {

            public int x; //not in use - only for learning purpose

            public int Length { get; set; }

            //default constructor must be called to assign defaulr value to x
            public Square(int len) : this() { Length = len; }

            public override string ToString() { return "Square len: " + Length; }

            
            // Rectangles can be explicitly converted into Squares. 
            public static explicit operator Square(Rectangle r)
            {
                Square s = new Square();
                s.Length = r.Height;
                return s;
            }
        }

        static void Main(string[] args)
        {

            Rectangle myRec = new Rectangle(3, 6);

            //Explicit cast
            Square mySquare = (Square)myRec;

            //Implicit cast (explicit is possible too)
            Rectangle myRec2 = mySquare;

            Console.ReadLine();
        }
    }
}
