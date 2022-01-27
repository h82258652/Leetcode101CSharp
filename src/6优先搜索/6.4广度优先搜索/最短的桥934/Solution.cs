using System.Collections.Generic;
using System.Drawing;

namespace 最短的桥934
{
    public class Solution
    {
        private int[] direction = new int[] { -1, 0, 1, 0, -1 };

        public int ShortestBridge(int[][] grid)
        {
            // 思路，先将第一个岛屿找出来，并找到这些点，然后不断扩散，每次扩散 1 个距离，直至找到另一个岛屿

            int m = grid.Length;
            int n = grid[0].Length;

            Queue<Point> points = new Queue<Point>();
            // dfs 寻找第一个岛屿，并把 1 全部赋值为 2
            bool flipped = false;
            for (int i = 0; i < m; i++)
            {
                if (flipped)
                {
                    break;
                }
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        dfs(points, grid, m, n, i, j);
                        flipped = true;
                        break;
                    }
                }
            }

            // bfs 寻找第二个岛屿，并把过程中经过的 0 赋值为 2
            int level = 0;
            while (points.Count > 0)
            {
                level++;
                int n_points = points.Count;
                while (n_points > 0)
                {
                    n_points--;

                    var r_c = points.Dequeue();

                    for (int k = 0; k < 4; k++)
                    {
                        int x = r_c.X + direction[k];
                        int y = r_c.Y + direction[k + 1];
                        if (x >= 0 && y >= 0 && x < m && y < n)
                        {
                            if (grid[x][y] == 2)
                            {
                                continue;
                            }

                            if (grid[x][y] == 1)
                            {
                                return level;
                            }

                            points.Enqueue(new Point(x, y));
                            grid[x][y] = 2;
                        }
                    }
                }
            }

            return 0;
        }

        private void dfs(Queue<Point> points, int[][] grid, int m, int n, int i, int j)
        {
            if (i < 0 || j < 0 || i == m || j == n || grid[i][j] == 2)
            {
                return;
            }

            if (grid[i][j] == 0)
            {
                points.Enqueue(new Point(i, j));
                return;
            }

            grid[i][j] = 2;
            dfs(points, grid, m, n, i - 1, j);
            dfs(points, grid, m, n, i + 1, j);
            dfs(points, grid, m, n, i, j - 1);
            dfs(points, grid, m, n, i, j + 1);
        }
    }
}
