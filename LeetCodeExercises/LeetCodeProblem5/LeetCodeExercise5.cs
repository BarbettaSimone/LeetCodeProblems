using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.LeetCodeProblem5
{
    internal class LeetCodeExercise5
    {
        public LeetCodeExercise5()
        {
            Console.WriteLine("Longest Palindromic Substring");

            // read the string
            Console.WriteLine("Insert the string:");
            string insertedStr = Console.ReadLine();
            Console.WriteLine("Inserted string: {0}", insertedStr);

            string palindromicStr = LeetCodeSolution5.FindPalindromicStr(insertedStr);
            Console.WriteLine("Output: {0}", palindromicStr);
        }
    }
}
