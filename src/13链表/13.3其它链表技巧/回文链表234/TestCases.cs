using FluentAssertions;
using Xunit;

namespace 回文链表234
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
                    next = new ListNode(2)
                    {
                        next = new ListNode(1)
                    }
                }
            };
            var result = solution.IsPalindrome(head);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var head = new ListNode(1)
            {
                next = new ListNode(2)
            };
            var result = solution.IsPalindrome(head);
            result.Should().BeFalse();
        }
    }
}
