using FluentAssertions;
using Xunit;

namespace 路径总和III437
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(10)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(3) { left = new TreeNode(3), right = new TreeNode(-2) },
                    right = new TreeNode(2) { right = new TreeNode(1) }
                },
                right = new TreeNode(-3) { right = new TreeNode(11) }
            };
            var solution = new Solution();
            var result = solution.PathSum(root, 8);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var root = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(11)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(2)
                    }
                },
                right = new TreeNode(8)
                {
                    left = new TreeNode(13)
                    {
                        left = new TreeNode(5),
                        right = new TreeNode(1)
                    },
                    right = new TreeNode(4)
                }
            };
            var solution = new Solution();
            var result = solution.PathSum(root, 22);
            result.Should().Be(3);
        }
    }
}
