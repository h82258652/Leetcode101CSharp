using System.Collections.Generic;

namespace 太平洋大西洋水流问题417
{
    public class Solution
    {
        private int[] direction = { -1, 0, 1, 0, -1 };

        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            // 思路，从 4 条边往上流，标记能流到的格子

            if (heights.Length == 0 || heights[0].Length == 0)
            {
                return new List<IList<int>>();
            }

            List<IList<int>> ans = new List<IList<int>>();
            int m = heights.Length;
            int n = heights[0].Length;

            bool[][] can_reach_p = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                can_reach_p[i] = new bool[n];
            }

            bool[][] can_reach_a = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                can_reach_a[i] = new bool[n];
            }

            for (int i = 0; i < m; i++)
            {
                dfs(heights, can_reach_p, i, 0);
                dfs(heights, can_reach_a, i, n - 1);
            }

            for (int i = 0; i < n; i++)
            {
                dfs(heights, can_reach_p, 0, i);
                dfs(heights, can_reach_a, m - 1, i);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (can_reach_p[i][j] && can_reach_a[i][j])
                    {
                        ans.Add(new List<int>() { i, j });
                    }
                }
            }

            return ans;
        }

        private void dfs(int[][] matrix, bool[][] can_reach, int r, int c)
        {
            if (can_reach[r][c])
            {
                return;
            }

            can_reach[r][c] = true;
            for (int i = 0; i < 4; i++)
            {
                int x = r + direction[i];
                int y = c + direction[i + 1];
                if (x >= 0 && x < matrix.Length &&
                    y >= 0 && y < matrix[0].Length &&
                    matrix[r][c] <= matrix[x][y])
                {
                    dfs(matrix, can_reach, x, y);
                }
            }
        }
    }
}
