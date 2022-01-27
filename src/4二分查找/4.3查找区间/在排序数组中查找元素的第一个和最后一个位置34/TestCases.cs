using FluentAssertions;
using Xunit;

namespace 在排序数组中查找元素的第一个和最后一个位置34
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 5, 7, 7, 8, 8, 10 };
            var target = 8;
            var result = solution.SearchRange(nums, target);
            result.Should().Equal(3, 4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { 5, 7, 7, 8, 8, 10 };
            var target = 6;
            var result = solution.SearchRange(nums, target);
            result.Should().Equal(-1, -1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var nums = new int[] { };
            var target = 0;
            var result = solution.SearchRange(nums, target);
            result.Should().Equal(-1, -1);
        }
    }
}
