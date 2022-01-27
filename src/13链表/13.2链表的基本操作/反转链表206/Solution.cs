namespace 反转链表206
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                var next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }

        public ListNode ReverseList2(ListNode head, ListNode prev)
        {
            if (head == null)
            {
                return prev;
            }

            ListNode next = head.next;
            head.next = prev;
            return ReverseList2(next, head);
        }
    }
}
