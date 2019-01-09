using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App31_LinqOverArrays
{
    class Program
    {

        static void QueryOverStrings()
        {
            string[] myVideoGames = { "Tyranny", "Counter Strike 2", "World of Tanks 3", "FTL 1" };

            //Build the expression to find the items in the array that have embedded space
            IEnumerable<string> subset = from g in myVideoGames where g.Contains(" ") orderby g select g;

            foreach (string s in subset)
                Console.WriteLine(s);

            ReflectOverQueryResult(subset);
        }

        static void QueryOverInts()
        {
            int[] myInts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Get only numbers less than 6 - you can use 'var' keyword instead explicit typing
            //IEnumerable<int> subset = from i in myInts where i < 6 select i; 
            //Real type is different but in most cases you may cast to generic IEnumerable<type> type

            var subset = from i in myInts where i < 6 select i;

            foreach (int i in subset)
                Console.WriteLine(i);

            ReflectOverQueryResult(subset);

            //new subset is not a type of Array, but new low-level type
            //usually it implements IEnumerable interface and it is extended 
            //with new set of methods, e.g.:  
            Console.WriteLine("subset.All(i => i >= 1): {0}", subset.All(i => i >= 1));

            //Immediete Execution
            int[] subsetAsIntArray = (from i in subset where i < 8 select i).ToArray<int>();
        }

        static void ReflectOverQueryResult(object queryResult)
        {
            Console.WriteLine("queryResult type is: {0}", queryResult.GetType().Name);
            Console.WriteLine("queryResult location is: {0}", queryResult.GetType().Assembly.GetName().Name);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("QueryOverStrings()");
            QueryOverStrings();
            Console.WriteLine("\nQueryOverInts()");
            QueryOverInts();
            Console.ReadLine();
        }
    }
}
