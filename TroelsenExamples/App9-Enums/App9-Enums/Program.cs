using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9_Enums
{
    class Program
    {

        enum EmpType
        {
            Manager,        //0
            LineManager,    //1
            Programmer,     //2
            Designer        //3
        }

        enum HdType
        {
            HDisk = 102,    //102
            RAM,            //103
            Monitor         //104
        }

        enum PriceType : long
        {
            Fixed = 99,
            NonFixed = 5
        }

        static void Main(string[] args)
        {
            HdType hdType = HdType.HDisk;
            AskForHdType(hdType);
            Console.WriteLine("hdType.toString(): {0} and integer value: {1}",hdType.ToString(),(System.Int32)hdType);
            Console.WriteLine();

            //Print all possible values for EmpType
            Console.WriteLine(Enum.GetValues(typeof(EmpType)));

            string[] myStr = new string[10];

            Console.WriteLine("myStr.TypeOf(): {0}", myStr.GetType());


            //get full set of EmpType enum
            Array empArray = Enum.GetValues(typeof(EmpType));
            Console.WriteLine("empArray.Length: {0}",empArray.Length);
             
            for(int i = 0; i < empArray.Length; i++)
                Console.WriteLine(empArray.GetValue(i));


            Console.ReadLine();
        }

        static void AskForHdType(HdType e)
        {
            switch(e)
            {
                case HdType.HDisk:
                    Console.WriteLine("Hard Disk");
                    break;
                case HdType.RAM:
                    Console.WriteLine("RAM Memory");
                    break;
                case HdType.Monitor:
                    Console.WriteLine("Output screen");
                    break;
                default:
                    Console.WriteLine("Unrecognized");
                    break;
            }
        }
    }
}
