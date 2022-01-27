using FluentAssertions;
using Xunit;

namespace 基本计算器II227
{
    public class TestCases
    {
        [Theory]
        [InlineData("3+2*2", 7)]
        [InlineData(" 3/2 ", 1)]
        [InlineData(" 3+5 / 2 ", 5)]
        public void Test(string s, int excepted)
        {
            var solution = new Solution();
            var result = solution.Calculate(s);
            result.Should().Be(excepted);
        }
    }
}
