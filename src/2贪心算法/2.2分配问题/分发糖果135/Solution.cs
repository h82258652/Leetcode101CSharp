using System;
using System.Linq;

namespace 分发糖果135
{
    public class Solution
    {
        public int Candy(int[] ratings)
        {
            var size = ratings.Length;
            if (size < 2)
            {
                return size;
            }

            var num = new int[size];
            Array.Fill(num, 1);// 每个孩子至少分配到 1 个糖果

            // 思路，因为需要比两边高，所以先走一遍从左往右，再走一遍从右往左
            for (var i = 1; i < size; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    num[i] = num[i - 1] + 1;
                }
            }

            for (var i = size - 1; i > 0; i--)
            {
                if (ratings[i] < ratings[i - 1])
                {
                    num[i - 1] = Math.Max(num[i - 1], num[i] + 1);
                }
            }

            return num.Sum();
        }
    }
}
