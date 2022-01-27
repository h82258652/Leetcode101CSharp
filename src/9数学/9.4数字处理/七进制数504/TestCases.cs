using FluentAssertions;
using Xunit;

namespace 七进制数504
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.ConvertToBase7(100);
            result.Should().Be("202");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.ConvertToBase7(-7);
            result.Should().Be("-10");
        }
    }
}
