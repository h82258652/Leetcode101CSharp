using FluentAssertions;
using Xunit;

namespace 颠倒二进制位190
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.reverseBits(0b00000010100101000001111010011100u);
            result.Should().Be(0b00111001011110000010100101000000u);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.reverseBits(0b11111111111111111111111111111101u);
            result.Should().Be(0b10111111111111111111111111111111u);
        }
    }
}
