using FluentAssertions;
using Xunit;

namespace 最长公共子序列1143
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.LongestCommonSubsequence("abcde", "ace");
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.LongestCommonSubsequence("abc", "abc");
            result.Should().Be(3);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.LongestCommonSubsequence("abc", "def");
            result.Should().Be(0);
        }
    }
}
