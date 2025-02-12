using LeetCodeExercises.LeetCodeProblem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.LeetCodeProblem2
{
    internal class LeetCodeExercise2
    {
        public LeetCodeExercise2()
        {
            int[] nums1 = { 2, 4, 3 };
            int[] nums2 = { 5, 6, 4 };
            Console.WriteLine("Add Two Numbers");
            Console.WriteLine("[{0}]", string.Join(", ", nums1));
            Console.WriteLine("[{0}]", string.Join(", ", nums2));
            LeetCodeSolution2 exercise = new LeetCodeSolution2();
            int[] output = Converter.ConvertListNodeToArray(exercise.AddTwoNumbers(Converter.ConvertArrayToListNode(nums1), Converter.ConvertArrayToListNode(nums2)));
            Console.WriteLine("Output: [{0}]", string.Join(", ", output));
        }
    }
}
