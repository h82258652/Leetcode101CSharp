using System;

namespace 最大正方形221
{
    public class Solution
    {
        public int MaximalSquare(char[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return 0;
            }

            // 思路，使用 dp 数组记录以当前格子为右下角的最大的正方形的边长

            int rows = matrix.Length;
            int columns = matrix[0].Length;
            int max_side = 0;

            int[,] dp = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        if (i == 0 || j == 0)
                        {
                            dp[i, j] = 1;
                        }
                        else
                        {
                            dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i, j - 1], dp[i - 1, j])) + 1;
                        }

                        max_side = Math.Max(max_side, dp[i, j]);
                    }
                }
            }

            return max_side * max_side;
        }
    }
}
