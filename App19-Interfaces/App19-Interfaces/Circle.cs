using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19_Interfaces
{
    class Circle : Shape
    {
        byte radius;

        public Circle()
        {
            shapeName = ShapeType.Circle;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
}
