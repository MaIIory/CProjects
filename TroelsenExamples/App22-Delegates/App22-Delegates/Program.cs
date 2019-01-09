using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App22_Delegates
{
    public delegate int BinaryOp(int x, int y);

    public class SimpleMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Substract(int x, int y)
        {
            return x - y;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            SimpleMath sm = new SimpleMath();

            //#1 Example
            BinaryOp b = new BinaryOp(sm.Add);

            foreach(Delegate d in b.GetInvocationList())
            {
                Console.WriteLine("b.Target: {0}", d.Target);
                Console.WriteLine("b.GetInvocationList(): {0}", d.Method);
            }

            Console.WriteLine("b(10,10): {0}",b(10,10)); //Invoke method is called here

            //#2 Example
            BinaryOp c = new BinaryOp(sm.Substract);


            Type myType = c.GetType();

            if(myType != null)
                Console.WriteLine("Type name: " + myType.ToString());
            else
                Console.WriteLine("myType is null");


            Console.WriteLine("c(20,10): {0}",c(20,10));
            Console.WriteLine("c.GetType(): {0}",c.GetType().BaseType);

            c.Invoke(30, 40);


            Console.ReadLine();
        }
    }
}
