using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars13_StringMix
{

    public struct StringPrefix
    {
        public int ltrNb;
        public char strInd;

        public StringPrefix(int ltrNb, char strInd)
        {
            this.ltrNb = ltrNb;
            this.strInd = strInd;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mix("Are they here", "yes, they are here");
            Console.ReadLine();
        }

        //change to return string
        public static string Mix(string s1, string s2)
        {

            char[] myArray = s1.ToCharArray();


            Dictionary<char, int> s1Dict = TranformStringToDict(s1);
            Dictionary<char, int> s2Dict = TranformStringToDict(s2);

            SortedDictionary<char, StringPrefix> resDict = new SortedDictionary<char, StringPrefix>();

            //List<string> keySet = new List<string>();
            //keySet.Sort((elem1,elem2) => elem2.ToArray<char>().Length.CompareTo(elem1.ToArray<char>().Length));

            foreach (KeyValuePair<char, int> kv in s1Dict)
                resDict.Add(kv.Key, new StringPrefix(kv.Value, '1'));

            foreach (KeyValuePair<char, int> kv in s2Dict)
            {
                try
                {
                    resDict.Add(kv.Key, new StringPrefix(kv.Value, '2'));
                }
                catch (ArgumentException)
                {
                    if(s2Dict[kv.Key] > s1Dict[kv.Key])
                        resDict[kv.Key] = new StringPrefix(kv.Value, '2');
                    else if(s2Dict[kv.Key] == s1Dict[kv.Key])
                        resDict[kv.Key] = new StringPrefix(kv.Value, '=');
                }
            }

            foreach(KeyValuePair<char, StringPrefix> kv in resDict.OrderByDescending(i => i.Value.ltrNb).ThenBy(i => i.Key))
                Console.WriteLine("kv.Key: {0}, kv.Value.ltrNb: {1}, kv.Value.strInd: {2}", kv.Key, kv.Value.ltrNb, kv.Value.strInd );


            string res = BuildOutput(resDict);
            Console.WriteLine(res);

            return res;
            


        }

        public static Dictionary<char, int> TranformStringToDict(string s)
        {

            Dictionary<char, int> resultDict = new Dictionary<char, int>();

            foreach (char c in s.ToArray<char>())
            {
                if (!Char.IsLower(c)) continue;
                int count = s.Count<char>(i => i == c);
                if (count > 1)
                    try
                    {
                        resultDict.Add(c, count);
                    }
                    catch (ArgumentException)
                    {
                        continue;
                    }
            }

            return resultDict;
        }

        public static string BuildOutput(SortedDictionary<char,StringPrefix> inputDict)
        {
            //StringBuilder resString = new StringBuilder("");

            //foreach (KeyValuePair<char, StringPrefix> kv in inputDict.OrderByDescending(i => i.Value.ltrNb).ThenByDescending(i => char.ConvertToUtf32(i.Key.ToString(), 0)))
            //{
            //    resString.Append(kv.Value.strInd.ToString() + ':');
            //    for(int i = 0; i < kv.Value.ltrNb; i++)
            //        resString.Append(kv.Key);
            //    resString.Append('/');
            //}

            List<string> list = new List<string>();
            foreach (KeyValuePair<char, StringPrefix> kv in inputDict)
            {
                StringBuilder resString = new StringBuilder("");
                resString.Append(kv.Value.strInd.ToString() + ':');
                for (int i = 0; i < kv.Value.ltrNb; i++)
                    resString.Append(kv.Key);
                list.Add(resString.ToString());
            }

            StringBuilder finalResult = new StringBuilder("");

            foreach (string s in list.OrderByDescending(i => i.Length).ThenBy(i => i.ToCharArray()[0]))
            {
                finalResult.Append(s);
                finalResult.Append('/');
            }

            return finalResult.ToString().TrimEnd('/');
        }
    }
}
