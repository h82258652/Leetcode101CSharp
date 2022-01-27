using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 组合77
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var n = 4;
            var k = 2;
            var result = solution.Combine(n, k);
            result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>(){2,4},
                new List<int>(){3,4},
                new List<int>(){2,3},
                new List<int>(){1,2},
                new List<int>(){1,3},
                new List<int>(){1,4}
            });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var n = 1;
            var k = 1;
            var result = solution.Combine(n, k);
            result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>(){1}
            });
        }
    }
}
