using FluentAssertions;
using Xunit;

namespace 两数之和II输入有序数组167
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var numbers = new[] { 2, 7, 11, 15 };
            var target = 9;
            var result = solution.TwoSum(numbers, target);
            result.Should().Equal(1, 2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var numbers = new[] { 2, 3, 4 };
            var target = 6;
            var result = solution.TwoSum(numbers, target);
            result.Should().Equal(1, 3);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var numbers = new[] { -1, 0 };
            var target = -1;
            var result = solution.TwoSum(numbers, target);
            result.Should().Equal(1, 2);
        }
    }
}
