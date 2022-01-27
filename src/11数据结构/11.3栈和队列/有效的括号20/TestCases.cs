using FluentAssertions;
using Xunit;

namespace 有效的括号20
{
    public class TestCases
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        public void Test(string s, bool excepted)
        {
            var solution = new Solution();
            var result = solution.IsValid(s);
            result.Should().Be(excepted);
        }
    }
}
