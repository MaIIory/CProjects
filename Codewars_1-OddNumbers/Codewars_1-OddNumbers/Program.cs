using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_1_OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            Console.WriteLine(find_it(array));
            Console.ReadLine();
        }


        public static int find_it(int[] seq)
        {
            Dictionary<int, int> resultDic = new Dictionary<int, int>();

            for(int i = 0; i < seq.Length; i++)
            {
                if (resultDic.ContainsKey(seq[i]))
                    resultDic[seq[i]]++;
                else
                    resultDic.Add(seq[i], 1);
            }

            foreach(KeyValuePair<int,int> elem in resultDic)
            {
                if (elem.Value % 2 != 0)
                    return elem.Key;
            }
            return 0;
        }
    }
}
