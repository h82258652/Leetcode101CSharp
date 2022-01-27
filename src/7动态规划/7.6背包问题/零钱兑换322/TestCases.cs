using FluentAssertions;
using Xunit;

namespace 零钱兑换322
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CoinChange(new int[] { 1, 2, 5 }, 11);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CoinChange(new int[] { 2 }, 3);
            result.Should().Be(-1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.CoinChange(new int[] { 1 }, 0);
            result.Should().Be(0);
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.CoinChange(new int[] { 1 }, 0);
            result.Should().Be(0);
        }

        [Fact]
        public void Test5()
        {
            var solution = new Solution();
            var result = solution.CoinChange(new int[] { 1 }, 2);
            result.Should().Be(2);
        }
    }
}
