using System;

namespace 二叉树的直径543
{
    public class Solution
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            var diameter = 0;
            Depth(root, ref diameter);
            return diameter;
        }

        private int Depth(TreeNode root, ref int diameter)
        {
            if (root == null)
            {
                return 0;
            }

            var leftDepth = Depth(root.left, ref diameter);
            var rightDepth = Depth(root.right, ref diameter);

            var depth = Math.Max(leftDepth, rightDepth) + 1;

            diameter = Math.Max(diameter, leftDepth + rightDepth);

            return depth;
        }
    }
}
