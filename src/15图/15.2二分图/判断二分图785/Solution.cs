﻿using System.Collections.Generic;

namespace 判断二分图785
{
    public class Solution
    {
        public bool IsBipartite(int[][] graph)
        {
            // 思路，利用队列和广度优先搜索，我们可以对未染色的节点进行染色，并且检查是否有颜色相同的
            // 相邻节点存在。注意在代码中，我们用 0 表示未检查的节点，用 1 和 2 表示两种不同的颜色。

            int n = graph.Length;
            if (n == 0)
            {
                return true;
            }

            int[] color = new int[n];
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (color[i] <= 0)
                {
                    q.Enqueue(i);
                    color[i] = 1;
                }

                while (q.Count > 0)
                {
                    int node = q.Dequeue();
                    foreach (var j in graph[node])
                    {
                        if (color[j] == 0)
                        {
                            q.Enqueue(j);
                            color[j] = color[node] == 2 ? 1 : 2;
                        }
                        else if (color[node] == color[j])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
