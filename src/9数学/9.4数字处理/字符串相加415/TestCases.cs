using FluentAssertions;
using Xunit;

namespace 字符串相加415
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.AddStrings("11", "123");
            result.Should().Be("134");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.AddStrings("456", "77");
            result.Should().Be("533");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.AddStrings("0", "0");
            result.Should().Be("0");
        }
    }
}
