using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4_BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalValDeclarations();
            NewingDataTypes();
            ObjectFuncionality();
            DataTypeFunctionality();
            CharFuncionality();
            ParseFromString();
            UseDataAndTimes();
            Console.ReadLine();
        }

        static void LocalValDeclarations()
        {
            //basic way for declaring variables
            Console.WriteLine("***Basic usage of datatypes***");
            int myInt = 0;
            string myString = "This is my string";
            bool b1 = true, b2 = false, b3 = b1;
            Console.WriteLine("b1: {0}, b2: {1}, b3: {2}",b1,b2,b3);
            b1 = false;
            Console.WriteLine("b1: {0}, b2: {1}, b3: {2}", b1, b2, b3);
            Console.WriteLine("myInt: {0}", myInt);
        }

        static void NewingDataTypes()
        {
            //declaring variables with initialization
            Console.WriteLine("***Declarations with initialization***");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("b: {0}, i: {1}, d: {2}, dt: {3}",b,i,d,dt);
        }

        static void ObjectFuncionality()
        {
            //all types dervies from Object type thus Object type provides some deafult behavious (methods) 
            //that can by used by other types  derived from Object
            Console.WriteLine("***Functionality derives from Object data type***");
            int i = 1;
            Console.WriteLine("GetType of i: {0}", i.GetType());
            Console.WriteLine("GetHashCode of i: {0}", i.GetHashCode());
            Console.WriteLine("GetTypeCode of i: {0}",i.GetTypeCode());
            Console.WriteLine("ToString of i: {0}", i.ToString());
            Console.WriteLine("Equals(2): {0}",i.Equals(2));
            Console.WriteLine("CompareTo(2): {0}",i.CompareTo(2));
        }

        static void DataTypeFunctionality()
        {
            //usage of methods related to numerical data types
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}",double.MaxValue);
            Console.WriteLine("Min of double: {0}",double.MinValue);
            Console.WriteLine("double.PositiveInfinity: {0}",double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",double.NegativeInfinity);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
        }

        static void CharFuncionality()
        {
            Console.WriteLine("=>char type Funcionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0} ", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
        }

        static void ParseFromString()
        {
            Console.WriteLine("\n=> Data type parsing");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99,870");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
        }

        static void UseDataAndTimes()
        {
            Console.WriteLine("\n=> Dates and Times");

            Console.WriteLine("Today's date is {0}",DateTime.Now);
            DateTime dt = new DateTime(2015, 10, 17); //year, month, day
            Console.WriteLine("The day of {0} is {1}", dt.ToShortDateString(), dt.DayOfWeek);

            dt.AddMonths(2);
            Console.WriteLine("Daylight saving: {0}", dt.IsDaylightSavingTime());

            TimeSpan ts = new TimeSpan(4, 50, 0); //hours, minutes, seconds
            Console.WriteLine(ts);

            ts = ts.Subtract(new TimeSpan(0,15,0));
            Console.WriteLine(ts);


           
            
        }
    }
}
