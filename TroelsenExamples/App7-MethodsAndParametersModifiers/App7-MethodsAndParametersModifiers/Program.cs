using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7_MethodsAndParametersModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 7, z = 0;
            Console.WriteLine("*** Narmal passing ***");
            Console.WriteLine($"x: {x}, y: {y}");
            Add(x, y);
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
            Console.WriteLine("*** out parameter ***");
            Add(x, y, out z);
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
            Console.WriteLine();
            Console.WriteLine("*** ref parameter ***");
            string s1 = "hello ";
            string s2 = "my friend";
            Console.WriteLine($"s1: {s1}, s2: {s2}");
            SwapString(s1,s2);
            Console.WriteLine($"s1: {s1}, s2: {s2}");
            SwapString(ref s1,ref s2);
            Console.WriteLine($"s1: {s1}, s2: {s2}");
            Console.WriteLine();
            Console.WriteLine("*** param parameter ***");
            Console.WriteLine("CalculateAverage(2.0, 3.4, 1.8, 7.1): {0}", CalculateAverage(2.0, 3.4, 1.8, 7.1));
            double[] doubles = { 2.0, 3.4, 1.8, 7.1 };
            Console.WriteLine("CalculateAverage(doubles): {0}", CalculateAverage(doubles));
            Console.WriteLine("CalculateAverage(): {0}",CalculateAverage());
            Console.WriteLine("*** optional arguments ***");
            Console.WriteLine("OptionalArguments(\"help me\"): {0}", OptionalArguments("help me"));
            Console.WriteLine("OptionalArguments(\"help me\",\"Lucyn\"): {0}", OptionalArguments("help me","Lucyn"));


            Console.ReadLine();
        }

        static void Add(int x, int y)
        {
            x++;
            y++;
            Console.WriteLine($"Inside Add(int x, int y) method, x: {x}, y: {y}");
        }

        static void Add(int x, int y, out int z)
        {
            //argument marked as out must be assigned in other case error will be called
            z = x + y;
        }

        static void SwapString(string s1, string s2)
        {
            Console.WriteLine("Swap String without ref keyword");
            string s3 = s1;
            s1 = s2;
            s2 = s3;
        }

        static void SwapString(ref string s1, ref string s2)
        {
            Console.WriteLine("Swap String with ref keyword");
            string s3 = s1;
            s1 = s2;
            s2 = s3;
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine($"{values.Length} doubles received");

            double sum = 0;

            if (values.Length <= 0)
                return sum;

            foreach (double v in values)
                sum += v;
            return sum / values.Length;
        }

        static string OptionalArguments(string message, string owner="Programmer")
        {
            return "Hi the message is" + message +", it is owed by" + owner;
        }

    }
}
