using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape[] shapeArray = { new Hexagon(), new Triangle(), new Circle() };

            foreach(Shape shape in shapeArray)
            {
                if(shape is IPointy)
                    Console.WriteLine("{0} is IPointy! Number of points: {1}",shape.shapeName,((IPointy)shape).GetNumberOfPoints());
                else
                    Console.WriteLine("{0} is not IPointy!", shape.shapeName.ToString());
            }

            //Clash name case - explicit interface implementation
            //check Square class implementation
            Square mySquare = new Square();
            mySquare.Draw();

            IDrawable myDrawableSquare = new Square();
            myDrawableSquare.Draw();

            IPointy myPointySquare = new Square();
            //Compilation error
            //Can't call draw method from IPointy perspective
            //myPointySquare.Draw();

            Console.ReadLine();
        }
    }
}
