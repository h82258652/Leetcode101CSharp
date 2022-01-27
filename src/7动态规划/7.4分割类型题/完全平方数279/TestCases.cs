using FluentAssertions;
using Xunit;

namespace 完全平方数279
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.NumSquares(12);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.NumSquares(13);
            result.Should().Be(2);
        }
    }
}
