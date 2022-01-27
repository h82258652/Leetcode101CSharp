using FluentAssertions;
using Xunit;

namespace 只出现一次的数字136
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.SingleNumber(new int[] { 2, 2, 1 });
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.SingleNumber(new int[] { 4, 1, 2, 1, 2 });
            result.Should().Be(4);
        }
    }
}
