using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 找到所有数组中消失的数字448
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.FindDisapperaredNumbers(new[] { 4, 3, 2, 7, 8, 2, 3, 1 });
            result.Should().Equal(new List<int>() { 5, 6 });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.FindDisapperaredNumbers(new int[] { 1, 1 });
            result.Should().Equal(new List<int>() { 2 });
        }
    }
}
