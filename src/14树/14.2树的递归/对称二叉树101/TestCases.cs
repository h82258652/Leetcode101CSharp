using FluentAssertions;
using Xunit;

namespace 对称二叉树101
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2) { left = new TreeNode(3), right = new TreeNode(4) },
                right = new TreeNode(2) { left = new TreeNode(4), right = new TreeNode(3) }
            };
            var result = solution.IsSymmetric(root);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(3)
                },
                right = new TreeNode(2)
                {
                    right = new TreeNode(3)
                }
            };
            var result = solution.IsSymmetric(root);
            result.Should().BeFalse();
        }
    }
}
