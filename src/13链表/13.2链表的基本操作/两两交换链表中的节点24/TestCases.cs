using FluentAssertions;
using Xunit;

namespace 两两交换链表中的节点24
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var head = new ListNode(2)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(3)
                    }
                }
            };
            var result = solution.SwapPairs(head);
            result.val.Should().Be(2);
            result.next.val.Should().Be(1);
            result.next.next.val.Should().Be(4);
            result.next.next.next.val.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.SwapPairs(null);
            result.Should().BeNull();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var head = new ListNode(1);
            var result = solution.SwapPairs(head);
            result.val.Should().Be(1);
        }
    }
}
