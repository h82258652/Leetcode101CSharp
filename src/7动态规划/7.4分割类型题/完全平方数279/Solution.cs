using System;

namespace 完全平方数279
{
    public class Solution
    {
        public int NumSquares(int n)
        {
            // 思路，状态转移不连续，dp[i] 依赖 dp[i - 1]、dp[i - 4]、dp[i - 9]……

            int[] dp = new int[n + 1];
            Array.Fill(dp, int.MaxValue);

            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j * j <= i; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }

            return dp[n];
        }
    }
}
