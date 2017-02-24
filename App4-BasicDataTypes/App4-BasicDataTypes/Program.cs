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
            BasicStringFunctionality();
            StringConcatenation();
            VerbatimString();
            StringEquality();
            FunWithStringBuilder();
            StringInterpolation();

            Console.ReadLine();
        }

        static void LocalValDeclarations()
        {
            //basic way for declaring variables
            Console.WriteLine("***Basic usage of datatypes***");
            int myInt = 0;
            string myString = "This is my string";
            bool b1 = true, b2 = false, b3 = b1;
            Console.WriteLine("b1: {0}, b2: {1}, b3: {2}", b1, b2, b3);
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
            Console.WriteLine("b: {0}, i: {1}, d: {2}, dt: {3}", b, i, d, dt);
        }

        static void ObjectFuncionality()
        {
            //all types dervies from Object type thus Object type provides some deafult behavious (methods) 
            //that can by used by other types  derived from Object
            Console.WriteLine("***Functionality derives from Object data type***");
            int i = 1;
            Console.WriteLine("GetType of i: {0}", i.GetType());
            Console.WriteLine("GetHashCode of i: {0}", i.GetHashCode());
            Console.WriteLine("GetTypeCode of i: {0}", i.GetTypeCode());
            Console.WriteLine("ToString of i: {0}", i.ToString());
            Console.WriteLine("Equals(2): {0}", i.Equals(2));
            Console.WriteLine("CompareTo(2): {0}", i.CompareTo(2));
        }

        static void DataTypeFunctionality()
        {
            //usage of methods related to numerical data types
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
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

            Console.WriteLine("Today's date is {0}", DateTime.Now);
            DateTime dt = new DateTime(2015, 10, 17); //year, month, day
            Console.WriteLine("The day of {0} is {1}", dt.ToShortDateString(), dt.DayOfWeek);

            dt.AddMonths(2);
            Console.WriteLine("Daylight saving: {0}", dt.IsDaylightSavingTime());

            TimeSpan ts = new TimeSpan(4, 50, 0); //hours, minutes, seconds
            Console.WriteLine(ts);

            ts = ts.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine(ts);
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("\n=> Basic String Functionality");
            string firstName = "Lucyn";

            Console.WriteLine("My first name: {0}: ", firstName);
            Console.WriteLine("My first name has {0} characters", firstName.Length);
            Console.WriteLine("My first name in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("My first name in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("Does first name containe 'y'?: {0}", firstName.Contains('y'));
            Console.WriteLine("Change Luc to poi: {0}", firstName.Replace("Luc", "poi"));
            Console.WriteLine("My first name: {0}: ", firstName);
        }

        static void StringConcatenation()
        {
            Console.WriteLine("\n=> String Concatenation");

            string s1 = "Hello my name is ";
            string s2 = "Lukasz";
            string s3 = s1 + s2;
            Console.WriteLine(s3);

            string s4 = "Hello my name is ";
            string s5 = "Lukasz";
            string s6 = String.Concat(s4, s5);
            Console.WriteLine(s6);
        }

        static void VerbatimString()
        {
            Console.WriteLine("\n=> Verbatim Strings");

            //error
            //Console.WriteLine("C:\myapp\dir\file");
            Console.WriteLine(@"C:\myapp\dir\file");

            string myLongString = @"This is a very
                                                 very
                                                    very
                                                       long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
        }

        static void StringEquality()
        {
            Console.WriteLine("\n=>String Equality");
            string s1 = "Hello!";
            string s2 = "Yo!";

            Console.WriteLine("s1: {0}", s1);
            Console.WriteLine("s2: {0}", s2);
            Console.WriteLine();

            //test equality
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!" );
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1.Equals(s2): {0}",s1.Equals(s2));
            Console.WriteLine("\"Yo!\".Equals(s2): {0}", "Yo!".Equals(s2));
        }

        static void StringAreImmutable()
        {
            Console.WriteLine("\n=>Strings are immutable, this all you have remembe:)");
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("\n=>Using String Builder");
            StringBuilder sb = new StringBuilder("*** My favorite games ***");
            sb.Append("\n");
            sb.AppendLine("Dizzy");
            sb.AppendLine("empty");
            sb.AppendLine("Dark Colony");
            sb.AppendLine("Earth 2140");
            Console.WriteLine("sb: {0}",sb);

            sb.Replace("empty", "Need for Speed");
            Console.WriteLine("sb: {0}",sb);
        }

        static void StringInterpolation()
        {
            Console.WriteLine("\n=>String Interpolation");
            int age = 28;
            string name = "Lucyn";

            string greeting = $"Hello {name} you are {age} years old.";
            Console.WriteLine(greeting);
            Console.WriteLine($"Bye {name.ToUpper()}! You will have {age + 1} next year!");
        }
    }
}
