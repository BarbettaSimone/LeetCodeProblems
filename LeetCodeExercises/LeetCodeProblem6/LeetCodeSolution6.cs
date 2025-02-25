using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises
{
    internal static class LeetCodeSolution6
    {
        public static string FindZigZag(string insertedStr, int numRows)
        {
            string foundStr = string.Empty;
            for (int i = 0; i < numRows; i++)
            {
                if (i < insertedStr.Length)
                {
                    foundStr = foundStr + insertedStr[i];
                    int x = 0;
                    while (i + x < insertedStr.Length)
                    {
                        bool firstMod = true;
                        bool secondMod = true;
                        int increase = (numRows - 1 - i) * 2;
                        if (increase > 0 && i + x + increase < insertedStr.Length)
                        {
                            foundStr = foundStr + insertedStr[i + x + increase];
                            x = x + increase;
                        }
                        else
                        {
                            x = x + increase;
                            firstMod = false;
                        }
                        increase = i * 2;
                        if (increase > 0 && i + x + increase < insertedStr.Length)
                        {
                            foundStr = foundStr + insertedStr[i + x + increase];
                            x = x + increase;
                        }
                        else
                        {
                            x = x + increase;
                            secondMod = false;
                        }
                        if (firstMod == false && secondMod == false)
                        {
                            x = x + numRows;
                            if (i + x < insertedStr.Length)
                            {
                                foundStr = foundStr + insertedStr[i + x];
                            }
                        }
                    }
                }
            }
            return foundStr;
        }
    }
}
