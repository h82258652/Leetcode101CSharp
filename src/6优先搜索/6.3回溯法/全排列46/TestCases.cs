using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 全排列46
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new int[] { 1, 2, 3 };
            var result = solution.Permute(nums);
            result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>(){1,2,3},
                new List<int>(){1,3,2},
                new List<int>(){2,1,3},
                new List<int>(){2,3,1},
                new List<int>(){3,1,2},
                new List<int>(){3,2,1}
            });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new int[] { 0, 1 };
            var result = solution.Permute(nums);
            result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>(){0,1},
                new List<int>(){1,0}
            });
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var nums = new int[] { 1 };
            var result = solution.Permute(nums);
            result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>(){1}
            });
        }
    }
}
