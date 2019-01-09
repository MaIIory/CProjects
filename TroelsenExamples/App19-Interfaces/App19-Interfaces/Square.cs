using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19_Interfaces
{
    class Square : Shape, IPointy, IDrawable
    {
        public Square()
        {
            shapeName = ShapeType.Square;
        }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }

        //Square class has a clash name on Draw() method:
        //Shape class as well as IDrawable interface
        //is forcing Square class to implemnt Draw method
        //It necessary to use explicit iterface implementation
        public override void Draw()
        {
            Console.WriteLine("Drawing square in default Draw() method.");
        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing square in IDrawable Draw() method.");
        }
    }
}
