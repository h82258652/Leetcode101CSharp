using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 太平洋大西洋水流问题417
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var heights = new int[][]
            {
                new int[]{1,2,2,3,5},
                new int[]{3,2,3,4,4},
                new int[]{2,4,5,3,1},
                new int[]{6,7,1,4,5},
                new int[]{5,1,1,2,4}
            };
            var result = solution.PacificAtlantic(heights);
            result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>(){0,4},
                new List<int>(){1,3},
                new List<int>(){1,4},
                new List<int>(){2,2},
                new List<int>(){3,0},
                new List<int>(){3,1},
                new List<int>(){4,0}
            });
        }
    }
}
