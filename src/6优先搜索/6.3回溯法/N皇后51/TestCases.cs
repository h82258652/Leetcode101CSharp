using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace N皇后51
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.SolveNQueens(4);
            result.Should().BeEquivalentTo(new List<IList<string>>()
            {
                new List<string>(){".Q..","...Q","Q...","..Q."},
                new List<string>(){"..Q.","Q...","...Q",".Q.."}
            });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.SolveNQueens(1);
            result.Should().BeEquivalentTo(new List<IList<string>>()
            {
                new List<string>(){"Q"}
            });
        }
    }
}
