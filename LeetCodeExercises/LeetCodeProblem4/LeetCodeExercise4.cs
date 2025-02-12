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
            Console.WriteLine("Median of Two Sorted Arrays");

            // read first list and convert to array
            Console.WriteLine("Insert the first list of positive integer numbers ordered, -1 to stop:");
            List<int> insertedNums = new List<int>();
            int convertedSelection = -1;
            while (!int.TryParse(Console.ReadLine(), out convertedSelection) ||
                convertedSelection != -1)
            {
                if (convertedSelection > 0)
                {
                    if (insertedNums.Count() == 0 || convertedSelection >= insertedNums.Last())
                    {
                        insertedNums.Add(convertedSelection);
                    }
                    else
                    {
                        Console.WriteLine("Values must be ordered");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong selection");
                }
            }
            int[] array1 = insertedNums.ToArray();

            // read second list and convert to array
            Console.WriteLine("Insert the second list of positive integer numbers ordered, -1 to stop:");
            insertedNums = new List<int>();
            convertedSelection = -1;
            while (!int.TryParse(Console.ReadLine(), out convertedSelection) ||
                convertedSelection != -1)
            {
                if (convertedSelection > 0)
                {
                    if (insertedNums.Count() == 0 || convertedSelection >= insertedNums.Last())
                    {
                        insertedNums.Add(convertedSelection);
                    }
                    else
                    {
                        Console.WriteLine("Values must be ordered");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong selection");
                }
            }
            int[] array2 = insertedNums.ToArray();

            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            double median = LeetCodeSolution4.PointerFindMedianSortedArrays(array1, array2);
            Console.WriteLine("Output: {0}", median.ToString());
        }
    }
}
