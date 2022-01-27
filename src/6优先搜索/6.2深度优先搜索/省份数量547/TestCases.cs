using FluentAssertions;
using Xunit;

namespace 省份数量547
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var isConnected = new[]
            {
                new[] { 1, 1, 0 },
                new[] { 1, 1, 0 },
                new[] { 0, 0, 1 }
            };
            var result = solution.FindCircleNum(isConnected);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var isConnected = new[]
            {
                new[] { 1, 0, 0 },
                new[] { 0, 1, 0 },
                new[] { 0, 0, 1 }
            };
            var result = solution.FindCircleNum(isConnected);
            result.Should().Be(3);
        }
    }
}
