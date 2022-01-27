using FluentAssertions;
using Xunit;

namespace 数组中的第K个最大元素215
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new int[] { 3, 2, 1, 5, 6, 4 };
            var k = 2;
            var result = solution.FindKthLargest(nums, k);
            result.Should().Be(5);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            var k = 4;
            var result = solution.FindKthLargest(nums, k);
            result.Should().Be(4);
        }
    }
}
