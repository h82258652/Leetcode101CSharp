using System;
using System.Collections.Generic;

namespace 最长连续序列128
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> num_set = new HashSet<int>();
            foreach (int num in nums)
            {
                num_set.Add(num);
            }

            int longestStreak = 0;

            foreach (int num in num_set)
            {
                if (!num_set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (num_set.Contains(currentNum + 1))
                    {
                        currentNum += 1;
                        currentStreak += 1;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }
    }
}
