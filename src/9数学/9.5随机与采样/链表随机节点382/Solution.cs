using System;

namespace 链表随机节点382
{
    public class Solution
    {
        private readonly ListNode _head;
        private readonly Random _random = new Random();

        public Solution(ListNode head)
        {
        }

        public int GetRandom()
        {
            // 思路
            // 第 1 个数概率为 1
            // 第 2 个数概率为 1/2，另 1/2 为前一个数
            // 第 3 个数概率为 1/3，另 2/3 为前一个数
            // 第 4 个数概率为 1/4，另 3/4 为前一个数
            // 第 n 个数概率为 1/n，另 (n-1)/n 为前一个数

            int reserve = 0;
            ListNode cur = _head;
            int count = 0;
            while (cur != null)
            {
                count++;
                int r = this._random.Next(count) + 1;
                if (r == count)
                {
                    reserve = cur.val;
                }

                cur = cur.next;
            }

            return reserve;
        }
    }
}
