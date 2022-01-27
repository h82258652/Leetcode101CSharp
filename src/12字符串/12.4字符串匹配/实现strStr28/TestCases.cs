using FluentAssertions;
using Xunit;

namespace 实现strStr28
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.StrStr("hello", "ll");
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.StrStr("aaaaa", "bba");
            result.Should().Be(-1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.StrStr("", "");
            result.Should().Be(0);
        }
    }
}
