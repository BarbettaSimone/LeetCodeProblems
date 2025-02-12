using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises
{
    internal static class LeetCodeSolution4
    {
        static int pt1, pt2;
        public static double SimpleFindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            List<int> array1 = nums1.ToList();
            List<int> array2 = nums2.ToList();
            array1.AddRange(array2);
            array1 = array1.Order().ToList();
            if (array1.Count() % 2 == 0)
            {
                double val1 = array1[array1.Count() / 2 - 1];
                double val2 = array1[array1.Count() / 2];
                median = (val1 + val2) / 2;
            }
            else
            {
                median = array1[(int)array1.Count() / 2];
            }
            return median;
        }

        public static double PointerFindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length = nums1.Length + nums2.Length;
            double median = 0;
            if (length % 2 == 0)
            {
                for (int i = 0; i < length / 2 - 1; i++)
                {
                    double tmp = MovePointer(nums1, nums2);
                }
                median = (MovePointer(nums1, nums2) + MovePointer(nums1, nums2)) / 2;
            }
            else
            {
                for (int i = 0; i < length / 2; i++)
                {
                    double tmp = MovePointer(nums1, nums2);
                }
                median = (MovePointer(nums1, nums2));
            }
            return median;
        }

        private static double MovePointer(int[] nums1, int[] nums2)
        {
            if (pt1 < nums1.Length && pt2 < nums2.Length)
            {
                return nums1[pt1] < nums2[pt2] ? nums1[pt1++] : nums2[pt2++];
            }
            else if (pt1 < nums1.Length)
            {
                return nums1[pt1++];
            }
            else if (pt2 < nums2.Length)
            {
                return nums2[pt2++];
            }
            return -1;
        }
    }
}
