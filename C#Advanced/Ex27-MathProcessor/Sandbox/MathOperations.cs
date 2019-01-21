using System;

namespace MathProcessor
{
    static public class MathOperations
    {
        static public void Add(float x, float y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }

        static public void Substract(float x, float y)
        {
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        }

        static public void Multiply(float x, float y)
        {
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        }

        static public void Divide(float x, float y)
        {
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
    }
}
