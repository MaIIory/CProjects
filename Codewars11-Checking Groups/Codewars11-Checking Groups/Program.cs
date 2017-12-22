using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars11_Checking_Groups
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Check(""));
            Console.ReadLine();
        }


        public static bool Check(string input)
        {
            char[] charInput = input.ToArray<char>();
            if (charInput.Length <= 0)
                return true;
            return checkClosedGroups(0, charInput);
        }

        public static bool checkClosedGroups(int currInd, char[] inArray)
        {
            if (currInd >= inArray.Length - 1) return false;
            else if (checkMatch(inArray[currInd],inArray[++currInd]))
            {
                if (currInd >= inArray.Length - 1 && inArray.Length < 3) return true;
                else
                {
                    List<char> subList = new List<char>();

                    for(int i = 0; i < inArray.Length; i++)
                        if (i != currInd && i != currInd - 1)
                            subList.Add(inArray[i]);

                    return checkClosedGroups(0, subList.ToArray<char>());
                }
            }
            else return checkClosedGroups(currInd, inArray);
        }

        public static bool checkMatch(char sign1, char sign2)
        {
            if (sign1 == '(' && sign2 == ')') return true;
            else if (sign1 == '[' && sign2 == ']') return true;
            else if (sign1 == '{' && sign2 == '}') return true;
            else return false;
        }
    }
}
