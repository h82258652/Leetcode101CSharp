using FluentAssertions;
using Xunit;

namespace 比特位计数338
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.CountBits(2);
            result.Should().Equal(0, 1, 1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CountBits(5);
            result.Should().Equal(0, 1, 1, 2, 1, 2);
        }
    }
}
