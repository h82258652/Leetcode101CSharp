using FluentAssertions;
using Xunit;

namespace 合并两个有序链表21
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var list1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                }
            };
            var list2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                }
            };
            var result = solution.MergeTwoLists(list1, list2);
            result.val.Should().Be(1);
            result.next.val.Should().Be(1);
            result.next.next.val.Should().Be(2);
            result.next.next.next.val.Should().Be(3);
            result.next.next.next.next.val.Should().Be(4);
            result.next.next.next.next.next.val.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MergeTwoLists(null, null);
            result.Should().BeNull();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var list2 = new ListNode(0);
            var result = solution.MergeTwoLists(null, list2);
            result.val.Should().Be(0);
        }
    }
}
