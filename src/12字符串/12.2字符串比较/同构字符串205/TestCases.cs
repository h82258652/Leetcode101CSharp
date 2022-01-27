using FluentAssertions;
using Xunit;

namespace 同构字符串205
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsIsomorphic("egg", "add");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsIsomorphic("foo", "bar");
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.IsIsomorphic("paper", "title");
            result.Should().BeTrue();
        }
    }
}
