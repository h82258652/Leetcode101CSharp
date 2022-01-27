using System;

namespace 爬楼梯70
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            int[] dp = new int[n + 1];
            Array.Fill(dp, 1);

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
