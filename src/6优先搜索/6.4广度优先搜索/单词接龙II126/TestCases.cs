using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 单词接龙II126
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.FindLadders("hit", "cog", new List<string>()
            {
                "hot",
                "dot",
                "dog",
                "lot",
                "log",
                "cog"
            });
            result.Should().BeEquivalentTo(new List<IList<string>>()
            {
                new List<string>(){"hit","hot","dot","dog","cog"},
                new List<string>(){"hit","hot","lot","log","cog"}
            });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.FindLadders("hit", "cog", new List<string>()
            {
                "hot",
                "dot",
                "dog",
                "lot",
                "log"
            });
            result.Should().BeEquivalentTo(new List<IList<string>>());
        }
    }
}
