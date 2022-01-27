using FluentAssertions;
using Xunit;

namespace 二叉树的最大深度104
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
            var result = solution.MaxDepth(root);
            result.Should().Be(3);
        }
    }
}
