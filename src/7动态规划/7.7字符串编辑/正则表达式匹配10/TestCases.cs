using FluentAssertions;
using Xunit;

namespace 正则表达式匹配10
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsMatch("aa", "a");
            result.Should().BeFalse();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsMatch("aa", "a*");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.IsMatch("ab", ".*");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.IsMatch("aab", "c*a*b");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test5()
        {
            var solution = new Solution();
            var result = solution.IsMatch("mississippi", "mis*is*p*");
            result.Should().BeFalse();
        }
    }
}
