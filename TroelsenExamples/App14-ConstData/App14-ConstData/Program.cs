using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14_ConstData
{
    //Utility class
    class MyMathClass
    {
        //regular member
        public static int zero = 0;

        //implicitly static, must be assigned during declaration
        public const float PI = 3.14f;

        //readonly field may be assigned in ctor (and only there), not static
        public static readonly DateTime startDate;

        static MyMathClass()
        {
            startDate = DateTime.Now;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyMathClass.zero = 1;
            //MyMathClass.PI = 2; -> Compilation error
            //MyMathClass.startDate = DateTime.Now; -> Compilation error
        }
    }
}
