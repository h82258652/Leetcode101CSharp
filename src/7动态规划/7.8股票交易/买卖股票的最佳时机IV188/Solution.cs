using System;

namespace 买卖股票的最佳时机IV188
{
    public class Solution
    {
        public int MaxProfit(int k, int[] prices)
        {
            int days = prices.Length;
            if (days < 2)
            {
                // 完成不了一次买卖
                return 0;
            }

            // 买卖次数多于天数
            if (k * 2 >= days)
            {
                return MaxProfitUnlimited(prices);
            }

            int[] buy = new int[k + 1];
            Array.Fill(buy, int.MinValue);

            int[] sell = new int[k + 1];

            for (int i = 0; i < days; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    buy[j] = Math.Max(buy[j], sell[j - 1] - prices[i]);
                    sell[j] = Math.Max(sell[j], buy[j] + prices[i]);
                }
            }

            return sell[k];
        }

        private int MaxProfitUnlimited(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }

            return maxProfit;
        }
    }
}
