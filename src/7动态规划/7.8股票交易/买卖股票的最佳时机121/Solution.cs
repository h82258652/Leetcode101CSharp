using System;

namespace 买卖股票的最佳时机121
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int sell = 0;
            int buy = int.MinValue;

            for (int i = 0; i < prices.Length; i++)
            {
                buy = Math.Max(buy, -prices[i]);

                sell = Math.Max(sell, buy + prices[i]);
            }

            return sell;
        }
    }
}
