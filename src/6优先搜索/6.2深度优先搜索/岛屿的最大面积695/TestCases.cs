using FluentAssertions;
using Xunit;

namespace 岛屿的最大面积695
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var grid = new[]
            {
                new[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                new[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
            };
            var result = solution.MaxAreaOfIsland(grid);
            result.Should().Be(6);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var grid = new[]
            {
                new[] { 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            var result = solution.MaxAreaOfIsland(grid);
            result.Should().Be(0);
        }
    }
}
