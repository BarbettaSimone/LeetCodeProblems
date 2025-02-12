using LeetCodeExercises.LeetCodeProblem4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeExercises.LeetCodeProblem1
{
    internal class LeetCodeExercise1
    {
        public LeetCodeExercise1()
        {
            Console.WriteLine("Two Sum");

            // read list and convert to array
            Console.WriteLine("Insert a list of positive integer numbers, -1 to stop:");
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
            int[] nums = insertedNums.ToArray();

            // read target
            int target = -1;
            Console.WriteLine("Insert the positive integer number:");
            while (!int.TryParse(Console.ReadLine(), out convertedSelection) ||
                convertedSelection != -1)
            {
                if (convertedSelection > 0)
                {
                    target = convertedSelection;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong selection");
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", nums));
            Console.WriteLine("{0}", string.Join(", ", target));
            LeetCodeSolution1 exercise = new LeetCodeSolution1();
            int [] output = exercise.TwoSum(nums, target);
            if (output[0] == -1)
            {
                Console.WriteLine("No existing couple of numbers for the target");
            }
            else
            {
                Console.WriteLine("Output: [{0}, {1}]", output[0], output[1]);
            }
        }
    }
}
