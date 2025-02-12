using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises
{
    internal class LeetCodeSolution3
    {
        internal int LengthOfLongestSubstring(string s)
        {
            List<char> substring = new List<char>();
            int maxCount = 0;
            foreach (char c in s.ToCharArray())
            {
                if (!substring.Contains(c))
                {
                    substring.Add(c);
                    if (substring.Count() > maxCount)
                    {
                        maxCount = substring.Count();
                    }
                }
                else
                {
                    foreach (var elem in substring.ToList())
                    {
                        substring.Remove(elem);
                        if (elem == c)
                        {
                            break;
                        }
                    }
                    substring.Add(c);
                }
            }
            return maxCount;
        }
    }
}
