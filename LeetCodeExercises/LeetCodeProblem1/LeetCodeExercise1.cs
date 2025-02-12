using LeetCodeExercises.LeetCodeProblem4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeExercises.LeetCodeProblem1
{
    internal class LeetCodeExercise1
    {
        public LeetCodeExercise1()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Console.WriteLine("Two Sum");
            Console.WriteLine("[{0}]", string.Join(", ", nums));
            Console.WriteLine("{0}", string.Join(", ", target));
            LeetCodeSolution1 exercise = new LeetCodeSolution1();
            int [] output = exercise.TwoSum(nums, target);
            Console.WriteLine("Output: [{0}, {1}]", output[0], output[1]);
        }
    }
}
