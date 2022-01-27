﻿using System;
using System.Linq;

namespace 按权重随机选择528
{
    public class Solution
    {
        private int[] pre;
        private int total;
        private Random ran = new Random();

        public Solution(int[] w)
        {
            pre = new int[w.Length];
            pre[0] = w[0];
            for (int i = 1; i < w.Length; ++i)
            {
                pre[i] = pre[i - 1] + w[i];
            }
            total = w.Sum();
        }

        public int PickIndex()
        {
            int x = ran.Next(1, total + 1);
            return BinarySearch(x);
        }

        private int BinarySearch(int x)
        {
            int low = 0, high = pre.Length - 1;
            while (low < high)
            {
                int mid = (high - low) / 2 + low;
                if (pre[mid] < x)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }
    }
}
