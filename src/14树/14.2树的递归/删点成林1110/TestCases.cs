using System.Linq;
using FluentAssertions;
using Xunit;

namespace 删点成林1110
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(7)
                }
            };
            var solution = new Solution();
            var result = solution.DelNodes(root, new[] { 3, 5 });
            result.Select(temp => temp.val).ToArray().Should().BeEquivalentTo(new[] { 1, 6, 7 });
        }

        [Fact]
        public void Test2()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(3)
                },
                right = new TreeNode(4)
            };
            var solution = new Solution();
            var result = solution.DelNodes(root, new[] { 3 });
            result.Count.Should().Be(1);
            result[0].val.Should().Be(1);
            result[0].left.val.Should().Be(2);
            result[0].right.val.Should().Be(4);
            result[0].left.left.Should().BeNull();
            result[0].left.right.Should().BeNull();
        }
    }
}
