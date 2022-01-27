using FluentAssertions;
using Xunit;

namespace 爬楼梯70
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.ClimbStairs(2);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.ClimbStairs(3);
            result.Should().Be(3);
        }
    }
}
