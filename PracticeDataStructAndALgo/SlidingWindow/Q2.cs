using System;

namespace PracticeDataStructAndALgo.SlidingWindow
{
    public class Q2
    {
        public static List<int> sales = new List<int> { 10, 20, 5, 30, 25, 15, 40, 10 };
        //find the maximum sum of any consecutive 3 days
        //window size is 3
        public static void Run()
        {


            int left = 0, windowSum = 0, maxSum = 0;
            int windowSize = 3;

            for (int right = 0; right < sales.Count; right++)
            {
                windowSum += sales[right];

                while (right - left + 1 > windowSize)
                {
                    windowSum -= sales[left];
                    left++;
                }
                maxSum = Math.Max(maxSum, windowSum);
            }

            Console.WriteLine($"maxSum of window 3 is: {maxSum}");

        }
    
    }
}