using FluentAssertions;
using Xunit;

namespace 判断二分图785
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var graph = new[]
            {
                new[] { 1, 2, 3 },
                new[] { 0, 2 },
                new[] { 0, 1, 3 },
                new[] { 0, 2 }
            };
            var result = solution.IsBipartite(graph);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var graph = new[]
            {
                new[] { 1, 3 },
                new[] { 0, 2 },
                new[] { 1, 3 },
                new[] { 0, 2 }
            };
            var result = solution.IsBipartite(graph);
            result.Should().BeTrue();
        }
    }
}
