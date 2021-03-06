namespace 只有两个键的键盘650
{
    public class Solution
    {
        public int MinSteps(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 2; i <= n; i++)
            {
                dp[i] = i;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dp[i] = dp[j] + dp[i / j];
                        break;
                    }
                }
            }

            return dp[n];
        }
    }
}
