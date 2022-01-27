using FluentAssertions;
using Xunit;

namespace SqrtX69
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var x = 4;
            var result = solution.MySqrt(x);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var x = 8;
            var result = solution.MySqrt(x);
            result.Should().Be(2);
        }
    }
}
