using FluentAssertions;
using Xunit;

namespace 两数之和1
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            result.Should().Equal(new int[] { 0, 1 });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
            result.Should().Equal(new int[] { 1, 2 });
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new int[] { 3, 3 }, 6);
            result.Should().Equal(new int[] { 0, 1 });
        }
    }
}
