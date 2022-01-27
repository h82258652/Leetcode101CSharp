using FluentAssertions;
using Xunit;

namespace 每日温度739
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
            result.Should().Equal(new int[] { 1, 1, 4, 2, 1, 1, 0, 0 });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.DailyTemperatures(new int[] { 30, 40, 50, 60 });
            result.Should().Equal(new int[] { 1, 1, 1, 0 });
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.DailyTemperatures(new int[] { 30, 60, 90 });
            result.Should().Equal(new int[] { 1, 1, 0 });
        }
    }
}
