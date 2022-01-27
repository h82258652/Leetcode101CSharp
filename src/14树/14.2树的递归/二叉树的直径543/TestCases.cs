using FluentAssertions;
using Xunit;

namespace 二叉树的直径543
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
            };
            var result = solution.DiameterOfBinaryTree(root);
            result.Should().Be(3);
        }
    }
}
