using FluentAssertions;
using Xunit;

namespace 阶乘后的零172
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.TrailingZeroes(3);
            result.Should().Be(0);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.TrailingZeroes(5);
            result.Should().Be(1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.TrailingZeroes(0);
            result.Should().Be(0);
        }
    }
}
