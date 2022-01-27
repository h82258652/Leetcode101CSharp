namespace 合并两个有序链表21
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list2 == null)
            {
                return list1;
            }

            if (list1==null)
            {
                return list2;
            }

            if (list1.val > list2.val)
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }

            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }

        public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(0);
            var node = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    node.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    node.next = list2;
                    list2 = list2.next;
                }

                node = node.next;
            }

            node.next = list1 ?? list2;
            return dummy.next;
        }
    }
}
