using System.Collections.Generic;

namespace 删点成林1110
{
    public class Solution
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            List<TreeNode> result = new List<TreeNode>();
            HashSet<int> deletes = new HashSet<int>(to_delete);
            result.Add(root);
            Dfs(root, deletes, result);
            return result;
        }

        private TreeNode Dfs(TreeNode root, HashSet<int> deletes, List<TreeNode> result)
        {
            if (root == null)
            {
                return null;
            }

            root.left = Dfs(root.left, deletes, result);
            root.right = Dfs(root.right, deletes, result);

            if (deletes.Contains(root.val))
            {
                if (root.left != null)
                {
                    result.Add(root.left);
                }
                if (root.right != null)
                {
                    result.Add(root.right);
                }

                if (result.Contains(root))
                {
                    result.Remove(root);
                }

                return null;
            }

            return root;
        }
    }
}
