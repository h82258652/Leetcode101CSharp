using FluentAssertions;
using Xunit;

namespace 恢复二叉搜索树99
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(3)
                {
                    right = new TreeNode(2)
                }
            };
            solution.RecoverTree(root);
            root.val.Should().Be(3);
            root.left.val.Should().Be(1);
            root.left.right.val.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(3)
            {
                left = new TreeNode(1),
                right = new TreeNode(4)
                {
                    left = new TreeNode(2)
                }
            };
            solution.RecoverTree(root);
            root.val.Should().Be(2);
            root.left.val.Should().Be(1);
            root.right.val.Should().Be(4);
            root.right.left.val.Should().Be(3);
        }
    }
}
