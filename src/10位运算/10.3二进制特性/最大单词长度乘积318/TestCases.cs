using FluentAssertions;
using Xunit;

namespace 最大单词长度乘积318
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MaxProduct(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" });
            result.Should().Be(16);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MaxProduct(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" });
            result.Should().Be(4);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.MaxProduct(new string[] { "a", "aa", "aaa", "aaaa" });
            result.Should().Be(0);
        }
    }
}
