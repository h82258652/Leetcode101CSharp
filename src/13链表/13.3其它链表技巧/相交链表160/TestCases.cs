using FluentAssertions;
using Xunit;

namespace 相交链表160
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var intersectionNode = new ListNode(8)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(5)
                }
            };
            var headA = new ListNode(4)
            {
                next = new ListNode(1)
                {
                    next = intersectionNode
                }
            };
            var headB = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(1)
                    {
                        next = intersectionNode
                    }
                }
            };
            var solution = new Solution();
            var result = solution.GetIntersectionNode(headA, headB);
            result.val.Should().Be(8);
        }

        [Fact]
        public void Test2()
        {
            var intersectionNode = new ListNode(2)
            {
                next = new ListNode(4)
            };
            var headA = new ListNode(1)
            {
                next = new ListNode(9)
                {
                    next = new ListNode(1)
                    {
                        next = intersectionNode
                    }
                }
            };
            var headB = new ListNode(3)
            {
                next = intersectionNode
            };
            var solution = new Solution();
            var result = solution.GetIntersectionNode(headA, headB);
            result.val.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var headA = new ListNode(2)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };
            var headB = new ListNode(1)
            {
                next = new ListNode(5)
            };
            var solution = new Solution();
            var result = solution.GetIntersectionNode(headA, headB);
            result.Should().BeNull();
        }
    }
}
