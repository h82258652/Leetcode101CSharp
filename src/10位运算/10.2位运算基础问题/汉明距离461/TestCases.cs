using FluentAssertions;
using Xunit;

namespace 汉明距离461
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.HammingDistance(1, 4);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.HammingDistance(3, 1);
            result.Should().Be(1);
        }
    }
}
