using System;

namespace 最佳买卖股票时机含冷冻期309
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }

            int n = prices.Length;

            int[][] f = new int[n][];
            for (var i = 0; i < f.Length; i++)
            {
                f[i] = new int[3];
            }
            // f[i][0]：手上持有股票的最大收益
            // f[i][1]：手上不持有股票，并且处于冷冻期中的累计最大收益
            // f[i][2]：手上不持有股票，并且不在冷冻期中的累计最大收益
            f[0][0] = -prices[0];

            for (int i = 1; i < n; i++)
            {
                f[i][0] = Math.Max(f[i - 1][0], f[i - 1][2] - prices[i]);
                f[i][1] = f[i - 1][0] + prices[i];
                f[i][2] = Math.Max(f[i - 1][1], f[i - 1][2]);
            }

            return Math.Max(f[n - 1][1], f[n - 1][2]);
        }
    }
}
