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
            Console.WriteLine("Add Two Numbers");

            // read first list and convert to array
            Console.WriteLine("Insert the first list of positive integer numbers, -1 to stop:");
            List<int> insertedNums = new List<int>();
            int convertedSelection = -1;
            while (!int.TryParse(Console.ReadLine(), out convertedSelection) ||
                convertedSelection != -1)
            {
                if (convertedSelection > 0)
                {
                    insertedNums.Add(convertedSelection);
                }
                else
                {
                    Console.WriteLine("Wrong selection");
                }
            }
            int[] nums1 = insertedNums.ToArray();

            // read second list and convert to array
            Console.WriteLine("Insert the second list of positive integer numbers, -1 to stop:");
            insertedNums = new List<int>();
            convertedSelection = -1;
            while (!int.TryParse(Console.ReadLine(), out convertedSelection) ||
                convertedSelection != -1)
            {
                if (convertedSelection > 0)
                {
                    insertedNums.Add(convertedSelection);
                }
                else
                {
                    Console.WriteLine("Wrong selection");
                }
            }
            int[] nums2 = insertedNums.ToArray();

            Console.WriteLine("[{0}]", string.Join(", ", nums1));
            Console.WriteLine("[{0}]", string.Join(", ", nums2));
            LeetCodeSolution2 exercise = new LeetCodeSolution2();
            int[] output = Converter.ConvertListNodeToArray(exercise.AddTwoNumbers(Converter.ConvertArrayToListNode(nums1), Converter.ConvertArrayToListNode(nums2)));
            Console.WriteLine("Output: [{0}]", string.Join(", ", output));
        }
    }
}
