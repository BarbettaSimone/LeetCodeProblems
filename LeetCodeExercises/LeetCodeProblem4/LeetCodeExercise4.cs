using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.LeetCodeProblem4
{
    internal class LeetCodeExercise4
    {
        public LeetCodeExercise4()
        {
            int[] array1 = { 1, 2, 7 };
            int[] array2 = { 3, 4 };
            Console.WriteLine("Median of Two Sorted Arrays");
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            double median = LeetCodeSolution4.PointerFindMedianSortedArrays(array1, array2);
            Console.WriteLine("Output: {0}", median.ToString());
        }
    }
}
