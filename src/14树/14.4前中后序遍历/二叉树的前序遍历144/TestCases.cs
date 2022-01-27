using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace 二叉树的前序遍历144
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            var result = solution.PreorderTraversal(root);
            result.Should().Equal(new List<int> { 1, 2, 3 });
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.PreorderTraversal(null);
            result.Should().BeEmpty();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var root = new TreeNode(1);
            var result = solution.PreorderTraversal(root);
            result.Should().Equal(new List<int> { 1 });
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
            };
            var result = solution.PreorderTraversal(root);
            result.Should().Equal(new List<int> { 1, 2 });
        }

        [Fact]
        public void Test5()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                right = new TreeNode(2)
            };
            var result = solution.PreorderTraversal(root);
            result.Should().Equal(new List<int> { 1, 2 });
        }
    }
}
