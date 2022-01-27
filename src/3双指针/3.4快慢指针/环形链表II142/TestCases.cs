using FluentAssertions;
using Xunit;

namespace 环形链表II142
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var head3 = new ListNode(3);
            var head2 = new ListNode(2);
            var head0 = new ListNode(0);
            var headMinus4 = new ListNode(-4);
            head3.next = head2;
            head2.next = head0;
            head0.next = headMinus4;
            headMinus4.next = head2;
            var result = solution.DetectCycle(head3);
            result.val.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var head1 = new ListNode(1);
            var head2 = new ListNode(2);
            head1.next = head2;
            head2.next = head1;
            var result = solution.DetectCycle(head1);
            result.val.Should().Be(1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var head1 = new ListNode(1);
            var result = solution.DetectCycle(head1);
            result.Should().BeNull();
        }
    }
}
