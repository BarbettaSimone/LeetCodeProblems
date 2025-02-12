using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.LeetCodeProblem3
{
    internal class LeetCodeExercise3
    {
        public LeetCodeExercise3()
        {
            string inputStr = "abcdalsjflskjdsfkdf";
            Console.WriteLine("Longest Substring Without Repeating Characters");
            Console.WriteLine(inputStr);
            LeetCodeSolution3 solution = new LeetCodeSolution3();
            int stringLength = solution.LengthOfLongestSubstring(inputStr);
            Console.WriteLine("Output: {0}", stringLength.ToString());
        }
    }
}
