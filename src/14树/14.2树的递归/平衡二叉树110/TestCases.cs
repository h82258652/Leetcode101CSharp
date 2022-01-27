using FluentAssertions;
using Xunit;

namespace 平衡二叉树110
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            var result = solution.IsBalanced(root);
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
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(4),
                        right = new TreeNode(4)
                    },
                    right = new TreeNode(3)
                },
                right = new TreeNode(2)
            };
            var result = solution.IsBalanced(root);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.IsBalanced(null);
            result.Should().BeTrue();
        }
    }
}
