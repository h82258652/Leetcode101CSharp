using FluentAssertions;
using Xunit;

namespace 反转链表206
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            var result = solution.ReverseList(head);
            result.val.Should().Be(5);
            result.next.val.Should().Be(4);
            result.next.next.val.Should().Be(3);
            result.next.next.next.val.Should().Be(2);
            result.next.next.next.next.val.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var head = new ListNode(1)
            {
                next = new ListNode(2)
            };
            var result = solution.ReverseList(head);
            result.val.Should().Be(2);
            result.next.val.Should().Be(1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.ReverseList(null);
            result.Should().BeNull();
        }
    }
}
