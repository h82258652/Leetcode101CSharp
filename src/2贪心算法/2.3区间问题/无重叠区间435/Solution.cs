using System;

namespace 无重叠区间435
{
    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return 0;
            }

            // 思路，优先将结尾区间的排序到前面

            var n = intervals.Length;
            Array.Sort(intervals, (x, y) => x[1] - y[1]);
            var removed = 0;
            var prev = intervals[0][1];
            for (var i = 1; i < n; i++)
            {
                if (intervals[i][0] < prev)
                {
                    removed++;
                }
                else
                {
                    prev = intervals[i][1];
                }
            }

            return removed;
        }
    }
}
