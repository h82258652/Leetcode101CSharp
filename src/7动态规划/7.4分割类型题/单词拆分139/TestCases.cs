using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 单词拆分139
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.WordBreak("leetcode", new List<string>() { "leet", "code" });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.WordBreak("applepenapple", new List<string>() { "apple", "pen" });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.WordBreak("catsandog", new List<string>()
            {
                "cats",
                "dog",
                "sand",
                "and",
                "cat"
            });
            result.Should().BeFalse();
        }
    }
}
