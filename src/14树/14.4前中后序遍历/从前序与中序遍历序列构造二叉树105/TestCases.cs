using FluentAssertions;
using Xunit;

namespace 从前序与中序遍历序列构造二叉树105
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var preorder = new[] { 3, 9, 20, 15, 7 };
            var inorder = new[] { 9, 3, 15, 20, 7 };
            var root = solution.BuildTree(preorder, inorder);
            root.val.Should().Be(3);
            root.left.val.Should().Be(9);
            root.right.val.Should().Be(20);
            root.right.left.val.Should().Be(15);
            root.right.right.val.Should().Be(7);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var preorder = new[] { -1 };
            var inorder = new[] { -1 };
            var root = solution.BuildTree(preorder, inorder);
            root.val.Should().Be(-1);
        }
    }
}
