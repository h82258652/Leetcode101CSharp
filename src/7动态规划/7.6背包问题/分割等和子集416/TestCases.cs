using FluentAssertions;
using Xunit;

namespace 分割等和子集416
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CanPartition(new int[] { 1, 5, 11, 5 });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CanPartition(new int[] { 1, 2, 3, 5 });
            result.Should().BeFalse();
        }
    }
}
