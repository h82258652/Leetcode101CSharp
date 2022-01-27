using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 为运算表达式设计优先级241
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.DiffWaysToCompute("2-1-1");
            result.Should().BeEquivalentTo(new List<int>() { 0, 2 });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.DiffWaysToCompute("2*3-4*5");
            result.Should().BeEquivalentTo(new List<int>() { -34, -14, -10, -10, 10 });
        }
    }
}
