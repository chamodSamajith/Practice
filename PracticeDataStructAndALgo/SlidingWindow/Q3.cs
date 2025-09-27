namespace PracticeDataStructAndALgo.SlidingWindow
{
    public class Q3
    {
        // You are given an array of integers nums and an integer k.
        // Your task is to find the maximum sum of any contiguous subarray of size k.
        // Input:
        // nums (integer array, length ≥ k)
        // k (positive integer ≤ length of nums)
        // Output:
        // An integer representing the maximum possible sum of a contiguous subarray of size k.
        // Example 1:
        // Input: nums = [2, 1, 5, 1, 3, 2], k = 3
        // Output: 9
        // Explanation: Subarray [5, 1, 3] has the maximum sum = 9.

        int[] nums = [2, 1, 5, 1, 3, 2]; int k = 3;

        public static void subarray(int[] arr, int k)
        {
            int left = 0, windowSum = 0, maxSum = 0;
            for (int right = 0; right < arr.Length - 1; right++)
            {
                windowSum += arr[right];

                while (right - left + 1 > k)
                {
                    windowSum -= arr[left];
                    left++;
                }
                maxSum = Math.Max(windowSum, maxSum);
            }
            Console.WriteLine($"max sum: {maxSum}");
        }

    }
}