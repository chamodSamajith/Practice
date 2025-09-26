using System;

namespace PracticeDataStructAndALgo.TwoPointers
{
    public class Q2
    {

        public static List<(int,int)> Run()
        {
            var numbers = new int[] { -5, -2, 0, 1, 2, 3, 5, 7, 8, 10 };
            int target = 5;
            //Using the two pointers technique, find all unique pairs of numbers that add up to the target.
            //             Expected Output
            // For target = 5, the pairs should be:
            // (-2, 7)
            // (0, 5)
            // (2, 3)
            int left = 0, right = numbers.Length - 1;
            List<(int,int)> nums = new List<(int,int)>();

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    nums.Add((numbers[left], numbers[right]));
                    left++; right --;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return nums;
        }

    }
}