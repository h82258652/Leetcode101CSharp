using FluentAssertions;
using Xunit;

namespace 滑动窗口最大值239
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            result.Should().Equal(new int[] { 3, 3, 5, 5, 6, 7 });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MaxSlidingWindow(new int[] { 1 }, 1);
            result.Should().Equal(new int[] { 1 });
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.MaxSlidingWindow(new int[] { 1, -1 }, 1);
            result.Should().Equal(new int[] { 1, -1 });
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.MaxSlidingWindow(new int[] { 9, 11 }, 2);
            result.Should().Equal(new int[] { 11 });
        }

        [Fact]
        public void Test5()
        {
            var solution = new Solution();
            var result = solution.MaxSlidingWindow(new int[] { 4, -2 }, 2);
            result.Should().Equal(new int[] { 4 });
        }
    }
}
