using FluentAssertions;
using Xunit;

namespace 搜索旋转排序数组II81
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 2, 5, 6, 0, 0, 1, 2 };
            var target = 0;
            var result = solution.Search(nums, target);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { 2, 5, 6, 0, 0, 1, 2 };
            var target = 3;
            var result = solution.Search(nums, target);
            result.Should().BeFalse();
        }
    }
}
