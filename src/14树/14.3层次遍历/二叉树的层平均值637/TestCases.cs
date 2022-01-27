using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 二叉树的层平均值637
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            var solution = new Solution();
            var result = solution.AverageOfLevels(root);
            result.Should().Equal(new List<double> { 3, 14.5, 11 });
        }
    }
}
