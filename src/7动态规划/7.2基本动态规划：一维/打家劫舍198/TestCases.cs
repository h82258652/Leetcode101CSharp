using FluentAssertions;
using Xunit;

namespace 打家劫舍198
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.Rob(new int[] { 1, 2, 3, 1 });
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.Rob(new[] { 2, 7, 9, 3, 1 });
            result.Should().Be(12);
        }
    }
}
