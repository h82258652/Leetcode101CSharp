using System;
using System.Collections.Generic;

namespace 直线上最多的点数149
{
    public class Solution
    {
        public int MaxPoints(int[][] points)
        {
            Dictionary<double, int> hash = new Dictionary<double, int>();// <斜率，点个数>
            int max_count = 0;
            int same = 1;
            int same_y = 1;
            for (int i = 0; i < points.Length; i++)
            {
                same = 1;
                same_y = 1;
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (points[i][1] == points[j][1])
                    {
                        same_y++;
                        if (points[i][0] == points[j][0])
                        {
                            same++;
                        }
                    }
                    else
                    {
                        double dx = points[i][0] - points[j][0];
                        double dy = points[i][1] - points[j][1];
                        var key = dx / dy;
                        hash.TryGetValue(key, out var count);
                        hash[key] = count + 1;
                    }
                }

                max_count = Math.Max(max_count, same_y);
                foreach (var item in hash)
                {
                    max_count = Math.Max(max_count, same + item.Value);
                }
                hash.Clear();
            }

            return max_count;
        }
    }
}
