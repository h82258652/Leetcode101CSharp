using System;

namespace 平衡二叉树110
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return Helper(root) != -1;
        }

        private int Helper(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = Helper(root.left);
            int right = Helper(root.right);

            if (left == -1 || right == -1 || Math.Abs(left - right) > 1)
            {
                return -1;
            }

            return 1 + Math.Max(left, right);
        }
    }
}
