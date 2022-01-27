using FluentAssertions;
using Xunit;

namespace 编辑距离72
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MinDistance("horse", "ros");
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MinDistance("intention", "execution");
            result.Should().Be(5);
        }
    }
}
