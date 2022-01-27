using System.Collections.Generic;

namespace 二叉树的前序遍历144
{
    public class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                result.Add(node.val);
                if (node.right != null)
                {
                    stack.Push(node.right);// 先右后左，保证左子树先遍历
                }

                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }

            return result;
        }
    }
}
