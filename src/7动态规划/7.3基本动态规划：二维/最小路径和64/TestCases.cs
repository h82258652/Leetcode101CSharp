using FluentAssertions;
using Xunit;

namespace 最小路径和64
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MinPathSum(new int[][]
            {
                new int[]{1,3,1},
                new int[]{1,5,1},
                new int[]{4,2,1}
            });
            result.Should().Be(7);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MinPathSum(new int[][]
            {
                new int[]{1,2,3},
                new int[]{4,5,6}
            });
            result.Should().Be(12);
        }
    }
}
