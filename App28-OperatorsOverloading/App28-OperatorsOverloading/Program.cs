using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App28_OperatorsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(2, 3);
            Point pt2 = new Point(3, 4);

            Point pt3 = pt1 + pt2;
            Console.WriteLine("pt3 values: {0}",pt3.ToString());

            Point pt4 = pt2 - pt1;
            Console.WriteLine("pt4 values: {0}",pt4.ToString());

            pt4 = pt4 + 2;
            pt4 = 2 + pt4;

            Console.WriteLine("++pt3: {0}", (++pt3).ToString());
            Console.WriteLine("pt3++: {0}", (pt3++).ToString());
            Console.WriteLine("pt3 values: {0}", pt3.ToString());


            Console.ReadLine();
        }
    }
}
