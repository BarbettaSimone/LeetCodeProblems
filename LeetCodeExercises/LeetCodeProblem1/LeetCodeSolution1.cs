using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises
{
    internal class LeetCodeSolution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> listNum = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count(); i++)
            {
                listNum[nums[i]] = i;
            }
            for (int i = 0; i < nums.Count(); i++)
            {
                int missingValue = target - nums[i];
                if (listNum.ContainsKey(missingValue) && listNum[missingValue] != i)
                {
                    return [i, listNum[missingValue]];
                }
            }
            return [-1, -1];
        }
    }
}
