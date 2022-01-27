using FluentAssertions;
using Xunit;

namespace 等差数列划分413
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.NumberOfArithmeticSlices(new int[] { 1, 2, 3, 4 });
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.NumberOfArithmeticSlices(new int[] { 1 });
            result.Should().Be(0);
        }
    }
}
