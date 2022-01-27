namespace 环形链表II142
{
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            // 思路
            // 第一次相遇的时候，fast 指针走了 2s 步，slow 指针走了 s 步
            // 设 a 为入环前的长度，b 为环的长度，则有
            // f = s + nb，n 为 圈数
            // 由 f = 2s 和 f = s + nb 得
            // s = nb，也就是慢指针的步数
            // 若此时让一个指针从 head 走 a 步，且 b 也在当前位置走 a 步，这时必然相遇，因为 a ≡ nb + a

            var slow = head;
            var fast = head;
            // 判断是否存在环路
            do
            {
                if (fast == null || fast.next == null)// 快指针已经走到结尾了，说明不存在环路
                {
                    return null;
                }

                fast = fast.next.next;
                slow = slow.next;
            } while (fast != slow);

            // 查找环路节点
            fast = head;
            while (fast != slow)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return fast;
        }
    }
}
