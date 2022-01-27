using System;

namespace 分发饼干455
{
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            var child = 0;
            var cookie = 0;
            // 给胃口值小的孩子分配小的饼干
            while (child < g.Length && cookie < s.Length)
            {
                if (g[child] <= s[cookie])
                {
                    child++;
                }

                cookie++;
            }

            return child;
        }
    }
}
