using FluentAssertions;
using Xunit;

namespace 最长连续序列128
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });
            result.Should().Be(9);
        }
    }
}
