using System;

namespace 解码方法91
{
    public class Solution
    {
        public int NumDecodings(string s)
        {
            int n = s.Length;
            if (n == 0)
            {
                return 0;
            }

            // 前导零的情况
            int prev = s[0] - '0';
            if (prev == 0)
            {
                return 0;
            }

            // 只有一个数的情况
            if (n == 1)
            {
                return 1;
            }

            int[] dp = new int[n + 1];
            Array.Fill(dp, 1);// 先假设字符串每一位都有一种解码方法

            for (int i = 2; i <= n; i++)
            {
                int cur = s[i - 1] - '0';
                if ((prev == 0 || prev > 2) && cur == 0)
                {
                    // 解码失败
                    return 0;
                }

                if ((prev < 2 && prev > 0) || prev == 2 && cur < 7)
                {
                    if (cur > 0)
                    {
                        // 可以单独解，也可以连着前一个解
                        dp[i] = dp[i - 2] + dp[i - 1];
                    }
                    else
                    {
                        // 当前数字只能连着前一个数字一起解
                        dp[i] = dp[i - 2];
                    }
                }
                else
                {
                    dp[i] = dp[i - 1];
                }

                prev = cur;
            }

            return dp[n];
        }
    }
}
