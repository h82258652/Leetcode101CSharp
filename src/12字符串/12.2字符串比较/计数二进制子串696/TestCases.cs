using FluentAssertions;
using Xunit;

namespace 计数二进制子串696
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CountBinarySubstrings("00110011");
            result.Should().Be(6);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CountBinarySubstrings("10101");
            result.Should().Be(4);
        }
    }
}
