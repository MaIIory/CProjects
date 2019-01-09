using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            ExplicitVarsDeclaration();
            ImplicitVarsDeclaration();
            Console.ReadLine();
        }

        static void ExplicitVarsDeclaration()
        {
            Console.WriteLine("*** Inside ExplicitVarsDeclaration ***");
            int myInt = 0;
            bool myBool = true;
            string myString = "myString";

            Console.WriteLine($"myInt: {myInt.GetType()}");
            Console.WriteLine($"myBool: {myBool.GetType()}");
            Console.WriteLine($"myString: {myString.GetType()}");
            Console.WriteLine();
        }

        static void ImplicitVarsDeclaration()
        {
            Console.WriteLine("*** Inside ImplicitVarsDeclaration ***");

            var myInt = 0;
            var myBool = true;
            var myString = "myString";

            Console.WriteLine($"myInt: {myInt.GetType()}");
            Console.WriteLine($"myBool: {myBool.GetType()}");
            Console.WriteLine($"myString: {myString.GetType()}");
            Console.WriteLine();
        }
    }
}
