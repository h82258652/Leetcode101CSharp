namespace 比特位计数338
{
    public class Solution
    {
        public int[] CountBits(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                dp[i] = (i & 1) > 0 ? dp[i - 1] + 1 : dp[i >> 1];
            }
            return dp;
        }
    }
}
