using FluentAssertions;
using Xunit;

namespace 回文子串647
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CountSubstrings("abc");
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CountSubstrings("aaa");
            result.Should().Be(6);
        }
    }
}
