using System.Collections.Generic;

namespace 从前序与中序遍历序列构造二叉树105
{
    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length <= 0)
            {
                return null;
            }

            Dictionary<int, int> hash = new Dictionary<int, int>();
            for (int i = 0; i < preorder.Length; i++)
            {
                hash[inorder[i]] = i;
            }

            return BuildTreeHelper(hash, preorder, 0, preorder.Length - 1, 0);
        }

        private TreeNode BuildTreeHelper(Dictionary<int, int> hash, int[] preorder, int s0, int e0, int s1)
        {
            if (s0 > e0)
            {
                return null;
            }

            int mid = preorder[s1];
            int index = hash[mid];
            int leftLen = index - s0 - 1;
            TreeNode node = new TreeNode(mid);
            node.left = BuildTreeHelper(hash, preorder, s0, index - 1, s1 + 1);
            node.right = BuildTreeHelper(hash, preorder, index + 1, e0, s1 + 2 + leftLen);
            return node;
        }
    }
}
