using System;

namespace 最小路径和64
{
    public class Solution
    {
        public int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            int[][] dp = new int[m][];
            for (int i = 0; i < m; i++)
            {
                dp[i] = new int[n];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[i][j] = grid[i][j];// 左上角
                    }
                    else if (i == 0)
                    {
                        dp[i][j] = dp[i][j - 1] + grid[i][j];// 第一行
                    }
                    else if (j == 0)
                    {
                        dp[i][j] = dp[i - 1][j] + grid[i][j];// 第一列
                    }
                    else
                    {
                        dp[i][j] = Math.Min(dp[i - 1][j], dp[i][j - 1]) + grid[i][j];
                    }
                }
            }

            return dp[m - 1][n - 1];
        }
    }
}
