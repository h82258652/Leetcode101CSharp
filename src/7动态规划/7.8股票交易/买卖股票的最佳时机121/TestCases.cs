using FluentAssertions;
using Xunit;

namespace 买卖股票的最佳时机121
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            result.Should().Be(5);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            result.Should().Be(0);
        }
    }
}
