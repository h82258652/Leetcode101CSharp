using FluentAssertions;
using Xunit;

namespace 解码方法91
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.NumDecodings("12");
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.NumDecodings("226");
            result.Should().Be(3);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.NumDecodings("0");
            result.Should().Be(0);
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.NumDecodings("06");
            result.Should().Be(0);
        }
    }
}
