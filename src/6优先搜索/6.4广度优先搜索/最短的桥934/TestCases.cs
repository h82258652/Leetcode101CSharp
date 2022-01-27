using FluentAssertions;
using Xunit;

namespace 最短的桥934
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var grid = new int[][]
            {
                new int[]{0,1},
                new int[]{1,0}
            };
            var result = solution.ShortestBridge(grid);
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var grid = new int[][]
            {
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 1 }
            };
            var result = solution.ShortestBridge(grid);
            result.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var grid = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 1 }
            };
            var result = solution.ShortestBridge(grid);
            result.Should().Be(1);
        }
    }
}
