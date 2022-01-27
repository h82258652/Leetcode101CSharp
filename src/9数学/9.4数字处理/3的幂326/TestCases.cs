using FluentAssertions;
using Xunit;

namespace _3的幂326
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsPowerOfThree(27);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsPowerOfThree(0);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.IsPowerOfThree(9);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.IsPowerOfThree(45);
            result.Should().BeFalse();
        }
    }
}
