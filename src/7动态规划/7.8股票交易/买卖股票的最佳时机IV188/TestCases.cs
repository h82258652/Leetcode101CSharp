using FluentAssertions;
using Xunit;

namespace 买卖股票的最佳时机IV188
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MaxProfit(2, new int[] { 2, 4, 1 });
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MaxProfit(2, new int[] { 3, 2, 6, 5, 0, 3 });
            result.Should().Be(7);
        }
    }
}
