using FluentAssertions;
using Xunit;

namespace 最多能完成排序的块769
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MaxChunksToSorted(new int[] { 4, 3, 2, 1, 0 });
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MaxChunksToSorted(new int[] { 1, 0, 2, 3, 4 });
            result.Should().Be(4);
        }
    }
}
