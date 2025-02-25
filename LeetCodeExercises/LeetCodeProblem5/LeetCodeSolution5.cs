using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises
{
    internal static class LeetCodeSolution5
    {
        public static string FindPalindromicStr(string insertedStr)
        {
            string foundStr = string.Empty;
            char[] listOfChar = insertedStr.ToCharArray();
            for(int i = 0; i < listOfChar.Length; i++)
            {
                List<char> tempChars = new List<char> { listOfChar[i] };
                int indexBefore = 1;
                int indexAfter = 1;
                while (i - indexBefore >= 0 && i + indexAfter < listOfChar.Length)
                {
                    if (listOfChar[i - indexBefore] == listOfChar[i + indexAfter])
                    {
                        tempChars.Insert(0, listOfChar[i - indexBefore]);
                        tempChars.Add(listOfChar[i + indexAfter]);
                        indexBefore++;
                        indexAfter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (tempChars.Count() > foundStr.Length)
                {
                    foundStr = new string(tempChars.ToArray());
                }
                tempChars.Clear();
                indexBefore = 0;
                indexAfter = 1;
                while (i - indexBefore >= 0 && i + indexAfter < listOfChar.Length)
                {
                    if (listOfChar[i - indexBefore] == listOfChar[i + indexAfter])
                    {
                        tempChars.Insert(0, listOfChar[i - indexBefore]);
                        tempChars.Add(listOfChar[i + indexAfter]);
                        indexBefore++;
                        indexAfter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (tempChars.Count() > foundStr.Length)
                {
                    foundStr = new string(tempChars.ToArray());
                }
            }
            return foundStr;
        }
    }
}
