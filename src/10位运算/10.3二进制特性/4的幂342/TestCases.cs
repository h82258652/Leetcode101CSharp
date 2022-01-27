using FluentAssertions;
using Xunit;

namespace _4的幂342
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsPowerOfFour(16);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsPowerOfFour(5);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.IsPowerOfFour(1);
            result.Should().BeTrue();
        }
    }
}
