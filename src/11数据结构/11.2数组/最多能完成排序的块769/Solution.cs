using System;

namespace 最多能完成排序的块769
{
    public class Solution
    {
        public int MaxChunksToSorted(int[] arr)
        {
            // 思路，如果当前最大值大于数组位置，则说明右边一定有小
            //       于数组位置的数字，需要把它也加入待排序的子数组；又因为数组只包含不重复的0 到n，所以
            //       当前最大值一定不会小于数组位置。所以每当当前最大值等于数组位置时，假设为p，我们可以
            //       成功完成一次分割，并且其与上一次分割位置q 之间的值一定是q +1 到p 的所有数字。

            int chunks = 0;
            int cur_max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cur_max = Math.Max(cur_max, arr[i]);
                if (cur_max == i)
                {
                    chunks++;
                }
            }

            return chunks;
        }
    }
}
