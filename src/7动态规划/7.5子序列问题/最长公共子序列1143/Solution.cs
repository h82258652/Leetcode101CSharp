using System;

namespace 最长公共子序列1143
{
    public class Solution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int m = text1.Length;
            var n = text2.Length;

            // 思路，建立二维 dp 数组，i 表示 text1 第 i 个字符结尾，j 表示 text2 第 j 个字符结尾，dp[i][j] 表示公共子序列长度

            int[,] dp = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[m, n];
        }
    }
}
