using FluentAssertions;
using Xunit;

namespace 直线上最多的点数149
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MaxPoints(new int[][]
            {
                new int[]{1,1},
                new int[]{2,2},
                new int[]{3,3}
            });
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MaxPoints(new int[][]
            {
                new int[]{1,1},
                new int[]{3,2},
                new int[]{5,3},
                new int[]{4,1},
                new int[]{2,3},
                new int[]{1,4}
            });
            result.Should().Be(4);
        }
    }
}
