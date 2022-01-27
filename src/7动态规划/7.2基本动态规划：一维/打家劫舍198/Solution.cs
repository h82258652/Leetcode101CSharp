using System;

namespace 打家劫舍198
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length <= 0)
            {
                return 0;
            }

            int n = nums.Length;

            int[] dp = new int[n + 1];
            dp[1] = nums[0];
            for (int i = 2; i <= n; i++)
            {
                dp[i] = Math.Max(
                    dp[i - 1],// 这个房子不偷，那么可以选前一个房子
                    nums[i - 1] + dp[i - 2]);// 这个房子偷了，那么前一个房子不能偷
            }

            return dp[n];
        }
    }
}
