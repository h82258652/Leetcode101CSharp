using FluentAssertions;
using Xunit;

namespace 有效的字母异位词242
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsAnagram("anagram", "nagaram");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsAnagram("rat", "car");
            result.Should().BeFalse();
        }
    }
}
