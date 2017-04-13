using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19_Interfaces
{
    enum ShapeType
    {
        Hexagon,
        Triangle,
        Circle,
        Square
    }

    abstract class Shape
    {

        public ShapeType shapeName;

        abstract public void Draw();
    }
}
