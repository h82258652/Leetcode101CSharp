using System;

namespace 岛屿的最大面积695
{
    public class Solution
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            int max_area = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    max_area = Math.Max(max_area, dfs(grid, i, j));
                }
            }

            return max_area;
        }

        private int dfs(int[][] grid, int r, int c)
        {
            if (r < 0 || r >= grid.Length ||
                c < 0 || c >= grid[0].Length || grid[r][c] == 0)
            {
                return 0;
            }

            grid[r][c] = 0;
            return 1 + dfs(grid, r + 1, c) + dfs(grid, r - 1, c) + dfs(grid, r, c + 1) + dfs(grid, r, c - 1);
        }
    }
}
