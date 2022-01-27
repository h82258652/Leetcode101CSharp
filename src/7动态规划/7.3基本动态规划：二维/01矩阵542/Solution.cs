using System;

namespace _01矩阵542
{
    public class Solution
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            // 思路，从左上往右下进行一次dp，再从右下往左上进行一次dp

            if (mat.Length == 0)
            {
                return new int[][] { };
            }

            int n = mat.Length;
            int m = mat[0].Length;
            int[][] dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[m];
                Array.Fill(dp[i], int.MaxValue - 1);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        dp[i][j] = 0;
                    }
                    else
                    {
                        if (j > 0)
                        {
                            dp[i][j] = Math.Min(dp[i][j], dp[i][j - 1] + 1);
                        }

                        if (i > 0)
                        {
                            dp[i][j] = Math.Min(dp[i][j], dp[i - 1][j] + 1);
                        }
                    }
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (mat[i][j] != 0)
                    {
                        if (j < m - 1)
                        {
                            dp[i][j] = Math.Min(dp[i][j], dp[i][j + 1] + 1);
                        }

                        if (i < n - 1)
                        {
                            dp[i][j] = Math.Min(dp[i][j], dp[i + 1][j] + 1);
                        }
                    }
                }
            }

            return dp;
        }
    }
}
