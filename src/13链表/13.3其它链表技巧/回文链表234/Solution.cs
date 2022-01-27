namespace 回文链表234
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }

            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            slow.next = ReverseList(slow.next);
            slow = slow.next;
            while (slow != null)
            {
                if (head.val != slow.val)
                {
                    return false;
                }

                head = head.next;
                slow = slow.next;
            }

            return true;
        }

        private ListNode ReverseList(ListNode head)
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
    }
}
