using FluentAssertions;
using Xunit;

namespace 合并两个有序数组88
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new[] { 2, 5, 6 };
            var n = 3;
            solution.Merge(nums1, m, nums2, n);
            nums1.Should().Equal(1, 2, 2, 3, 5, 6);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums1 = new[] { 1 };
            var m = 1;
            var nums2 = new int[] { };
            var n = 0;
            solution.Merge(nums1, m, nums2, n);
            nums1.Should().Equal(1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var nums1 = new[] { 0 };
            var m = 0;
            var nums2 = new[] { 1 };
            var n = 1;
            solution.Merge(nums1, m, nums2, n);
            nums1.Should().Equal(1);
        }
    }
}
