﻿namespace 只出现一次的数字136
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int ans = 0;
            foreach (var num in nums)
            {
                ans ^= num;
            }

            return ans;
        }
    }
}
