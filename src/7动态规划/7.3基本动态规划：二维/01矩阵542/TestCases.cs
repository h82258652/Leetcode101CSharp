using FluentAssertions;
using Xunit;

namespace _01矩阵542
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.UpdateMatrix(new int[][]
            {
                new int[]{0,0,0},
                new int[]{0,1,0},
                new int[]{0,0,0}
            });

            result.Should().BeEquivalentTo(new int[][]
            {
                new int[]{0,0,0},
                new int[]{0,1,0},
                new int[]{0,0,0}
            });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.UpdateMatrix(new int[][]
            {
                new int[]{0,0,0},
                new int[]{0,1,0},
                new int[]{1,1,1}
            });

            result.Should().BeEquivalentTo(new int[][]
            {
                new int[]{0,0,0},
                new int[]{0,1,0},
                new int[]{1,2,1}
            });
        }
    }
}
