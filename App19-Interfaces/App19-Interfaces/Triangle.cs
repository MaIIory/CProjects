using System;

namespace App19_Interfaces
{
    class Triangle : Shape, IPointy
    {
        public byte nbOfPoints = 3;

        public Triangle()
        {
            shapeName = ShapeType.Triangle;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public byte GetNumberOfPoints()
        {
            return nbOfPoints;
        }
    }
}
