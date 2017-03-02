using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleArrays();
            ArrayInitialization();
            ArrayOfObjects();
            RectangularMultidimensionalArray();
            JaggedMultidimensionalArray();
            SystemArrayFuncionality();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation");
            int[] myInts = new int[3];

            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach(int i in myInts)
                Console.WriteLine($"myInts: {i}");

            string[] myString = new string[100];
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("\n=> Array Initialization");
            int[] myInts = { 1, 23, 56, 234, 2 };
            Console.WriteLine("MyInts.Length: {0}",myInts.Length);
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("\n=> ArrayOfObjects");

            object[] myObjects = new object[4];
            myObjects[0] = 100;
            myObjects[1] = "hello";
            myObjects[2] = true;
            myObjects[3] = new object();

            Console.WriteLine("myObjects types: ");
            foreach(object obj in myObjects)
                Console.WriteLine("{0} is type of {1}",obj.ToString(),obj.GetType());
        }

        static void RectangularMultidimensionalArray()
        {
            Console.WriteLine("\n=> Rectangular Multidimensional Array");
            //FIXED length of every array
            int[,] myMatrix = new int[3, 4];


            Console.WriteLine("MyMatrix.Length: {0}",myMatrix.Length);
            Console.WriteLine("MyMatrix.Rank:   {0}",myMatrix.Rank);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            foreach(int i in myMatrix)
                Console.WriteLine(i);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write("\t {0}", myMatrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("myMatrix[1][1]: {0}", myMatrix[1,1]);
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("\n=> Jagged Multidimensional Array");
            //Every array may have different length

            int[][] myJagArray = new int[5][];

            Console.WriteLine("MyJagArray.Length: {0}", myJagArray.Length);
            Console.WriteLine("myJagArray.Rank:   {0}", myJagArray.Rank);

            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 1];
            }

            for (int i = 0; i < myJagArray.Length; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write("\t {0}", myJagArray[i][j]);
                Console.WriteLine();
            }
        }

        static void SystemArrayFuncionality()
        {
            Console.WriteLine("\n=> Array Funcionality");

            string[] games = { "Fallout", "Gothic", "Half-Life", "Dark Colony" };

            Console.WriteLine("My games array: ");
            foreach(string s in games)
                Console.Write("\t{0}",s);

            Console.WriteLine("Perform reverse action...");
            Array.Reverse(games);
            foreach (string s in games)
                Console.Write("\t{0}", s);

            Console.WriteLine("\nAnd clear action...");
            Array.Clear(games, 1,2);
            foreach (string s in games)
                Console.Write("\t{0}", s);
        }
    }
}
