using FluentAssertions;
using Xunit;

namespace 最长递增子序列300
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.LengthOfLIS(new int[] { 0, 1, 0, 3, 2, 3 });
            result.Should().Be(4);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.LengthOfLIS(new int[] { 7, 7, 7, 7, 7, 7, 7 });
            result.Should().Be(1);
        }
    }
}
