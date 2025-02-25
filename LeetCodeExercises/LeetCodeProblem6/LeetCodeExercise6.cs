using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.LeetCodeProblem5
{
    internal class LeetCodeExercise6
    {
        public LeetCodeExercise6()
        {
            Console.WriteLine("ZigZag conversion");

            // read the string
            Console.WriteLine("Insert the string:");
            string insertedStr = Console.ReadLine();
            Console.WriteLine("Insert number of rows");
            int.TryParse(Console.ReadLine(), out int numRows);
            if (numRows == 0)
            {
                Console.WriteLine("Wrong number of rows inserted");
                return;
            }

            Console.WriteLine("Inserted string: {0}", insertedStr);
            Console.WriteLine("Number of rows: {0}", numRows);
            string palindromicStr = LeetCodeSolution6.FindZigZag(insertedStr, numRows);
            Console.WriteLine("Output: {0}", palindromicStr);
        }
    }
}
