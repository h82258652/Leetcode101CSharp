using FluentAssertions;
using Xunit;

namespace 分发饼干455
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var g = new[] { 1, 2, 3 };
            var s = new[] { 1, 1, };
            var result = solution.FindContentChildren(g, s);
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var g = new[] { 1, 2 };
            var s = new[] { 1, 2, 3 };
            var result = solution.FindContentChildren(g, s);
            result.Should().Be(2);
        }
    }
}
