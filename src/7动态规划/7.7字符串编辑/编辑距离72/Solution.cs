using System;

namespace 编辑距离72
{
    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            int m = word1.Length;
            int n = word2.Length;
            int[][] dp = new int[m + 1][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[n + 1];
            }

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0)
                    {
                        dp[i][j] = j;
                    }
                    else if (j == 0)
                    {
                        dp[i][j] = i;
                    }
                    else
                    {
                        if (word1[i - 1] == word2[j - 1])
                        {
                            dp[i][j] = dp[i - 1][j - 1];
                        }
                        else
                        {
                            dp[i][j] = Math.Min(Math.Min(
                                dp[i - 1][j - 1],// 替换字符
                                dp[i][j - 1]// word2 删除一个字符可以变成 word1
                            ), dp[i - 1][j])// word1 删除一个字符可以变成 word2
                                       + 1;
                        }
                    }
                }
            }

            return dp[m][n];
        }
    }
}
