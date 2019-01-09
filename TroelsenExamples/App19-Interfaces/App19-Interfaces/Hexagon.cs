using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19_Interfaces
{
    class Hexagon : Shape, IPointy
    {
        private byte nbOfPoints = 6;

        public Hexagon()
        {
            shapeName = ShapeType.Hexagon;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing hexagon");
        }

        public byte GetNumberOfPoints()
        {
            return nbOfPoints;
        }
    }
}
