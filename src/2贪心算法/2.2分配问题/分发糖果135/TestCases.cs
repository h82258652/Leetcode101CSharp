using FluentAssertions;
using Xunit;

namespace 分发糖果135
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var ratings = new[] { 1, 0, 2 };
            var result = solution.Candy(ratings);
            result.Should().Be(5);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var ratings = new[] { 1, 2, 2 };
            var result = solution.Candy(ratings);
            result.Should().Be(4);
        }
    }
}
