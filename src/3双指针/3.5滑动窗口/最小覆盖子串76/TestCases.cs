using FluentAssertions;
using Xunit;

namespace 最小覆盖子串76
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var s = "ADOBECODEBANC";
            var t = "ABC";
            var result = solution.MinWindow(s, t);
            result.Should().Be("BANC");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var s = "a";
            var t = "a";
            var result = solution.MinWindow(s, t);
            result.Should().Be("a");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var s = "a";
            var t = "aa";
            var result = solution.MinWindow(s, t);
            result.Should().Be("");
        }
    }
}
