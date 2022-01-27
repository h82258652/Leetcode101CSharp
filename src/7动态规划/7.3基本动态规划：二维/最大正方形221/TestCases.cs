using FluentAssertions;
using Xunit;

namespace 最大正方形221
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MaximalSquare(new char[][]
            {
                new char[]{'1','0','1','0','0'},
                new char[]{'1','0','1','1','1'},
                new char[]{'1','1','1','1','1'},
                new char[]{'1','0','0','1','0'}
            });
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MaximalSquare(new char[][]
            {
                new char[]{'0','1'},
                new char[]{'1','0'},
            });
            result.Should().Be(1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.MaximalSquare(new char[][]
            {
                new char[]{'0'},
            });
            result.Should().Be(0);
        }
    }
}
