using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App30_ExtensionMethods
{

    //Extend object type
    static class MyExtensions
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}\n", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Now every object can use DisplayDefiningAssembly
            int x = 5;
            x.DisplayDefiningAssembly();
            Console.ReadLine();
        }
    }
}
