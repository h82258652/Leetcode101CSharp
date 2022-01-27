using FluentAssertions;
using Xunit;

namespace 一和零474
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            string[] strs = new string[] { "10", "0001", "111001", "1", "0" };
            int m = 5;
            int n = 3;
            var result = solution.FindMaxForm(strs, m, n);
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            string[] strs = new string[] { "10", "0", "1" };
            int m = 1;
            int n = 1;
            var result = solution.FindMaxForm(strs, m, n);
            result.Should().Be(2);
        }
    }
}
