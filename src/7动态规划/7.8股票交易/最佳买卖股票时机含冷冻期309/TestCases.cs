using FluentAssertions;
using Xunit;

namespace 最佳买卖股票时机含冷冻期309
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MaxProfit(new int[] { 1, 2, 3, 0, 2 });
            result.Should().Be(3);
        }
    }
}
