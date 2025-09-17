using System;
using System.Collections.Generic;

namespace PracticeDataStructAndALgo.SlidingWindow
{
// Given a string s and an integer k, return the length of the longest substring that contains at most k distinct characters.

// 🔹 Example
// Input: s = "eceba", k = 2
// Output: 3
// Explanation: "ece" is the longest substring with at most 2 distinct characters.

public static class Q1
    {
        public static void Solve()
        {
            string s = "eceba";
            int k = 2;

            int maxLen = LongestSubstringKDistinct(s, k);
            Console.WriteLine($"Longest substring with at most {k} distinct characters: {maxLen}");
        }

        private static int LongestSubstringKDistinct(string s, int k)
        {
            if (string.IsNullOrEmpty(s) || k == 0)
                return 0;

            int left = 0, maxLen = 0;
            var freq = new Dictionary<char, int>();

            for (int right = 0; right < s.Length; right++)
            {
                char rightChar = s[right];
                if (!freq.ContainsKey(rightChar))
                    freq[rightChar] = 0;
                freq[rightChar]++;

                // Shrink window if more than k distinct chars
                while (freq.Count > k)
                {
                    char leftChar = s[left];
                    freq[leftChar]--;
                    if (freq[leftChar] == 0)
                        freq.Remove(leftChar);
                    left++;
                }

                maxLen = Math.Max(maxLen, right - left + 1);
            }

            return maxLen;
        }
    }
}