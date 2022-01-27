using FluentAssertions;
using Xunit;

namespace 计数质数204
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CountPrimes(10);
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CountPrimes(0);
            result.Should().Be(0);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.CountPrimes(1);
            result.Should().Be(0);
        }
    }
}
