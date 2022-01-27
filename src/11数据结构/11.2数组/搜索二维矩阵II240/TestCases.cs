using FluentAssertions;
using Xunit;

namespace 搜索二维矩阵II240
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.SearchMatrix(new int[][]
            {
                new int[]{1,4,7,11,15},
                new int[]{2,5,8,12,19},
                new int[]{3,6,9,16,22},
                new int[]{10,13,14,17,24},
                new int[]{18,21,23,26,30}
            }, 5);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.SearchMatrix(new int[][]
            {
                new int[]{1,4,7,11,15},
                new int[]{2,5,8,12,19},
                new int[]{3,6,9,16,22},
                new int[]{10,13,14,17,24},
                new int[]{18,21,23,26,30}
            }, 20);
            result.Should().BeFalse();
        }
    }
}
