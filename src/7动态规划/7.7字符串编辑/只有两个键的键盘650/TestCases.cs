using FluentAssertions;
using Xunit;

namespace 只有两个键的键盘650
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MinSteps(3);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MinSteps(1);
            result.Should().Be(0);
        }
    }
}
