namespace 两两交换链表中的节点24
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var first = head;
            var second = head.next;
            var third = head.next.next;

            second.next = first;
            first.next = SwapPairs(third);

            return second;
        }
    }
}
