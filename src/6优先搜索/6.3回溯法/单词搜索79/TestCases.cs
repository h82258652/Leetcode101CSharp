using FluentAssertions;
using Xunit;

namespace 单词搜索79
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            var word = "ABCCED";
            var result = solution.Exist(board, word);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            var word = "SEE";
            var result = solution.Exist(board, word);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            var word = "ABCB";
            var result = solution.Exist(board, word);
            result.Should().BeFalse();
        }
    }
}
