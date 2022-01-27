using System;

namespace 二叉树的最大深度104
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            return root != null ? 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right)) : 0;
        }
    }
}
