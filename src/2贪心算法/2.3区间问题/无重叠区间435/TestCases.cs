using FluentAssertions;
using Xunit;

namespace 无重叠区间435
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var intervals = new[]
            {
                new[] { 1, 2 },
                new[] { 2, 3 },
                new[] { 3, 4 },
                new[] { 1, 3 }
            };
            var result = solution.EraseOverlapIntervals(intervals);
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var intervals = new[]
            {
                new[] { 1, 2 },
                new[] { 1, 2 },
                new[] { 1, 2 },
            };
            var result = solution.EraseOverlapIntervals(intervals);
            result.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var intervals = new[]
            {
                new[] { 1, 2 },
                new[] { 2, 3 }
            };
            var result = solution.EraseOverlapIntervals(intervals);
            result.Should().Be(0);
        }
    }
}
