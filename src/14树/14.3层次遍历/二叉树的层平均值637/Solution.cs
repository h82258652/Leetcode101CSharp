using System.Collections.Generic;

namespace 二叉树的层平均值637
{
    public class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();
            var nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                var levelCount = nodes.Count;
                var sum = 0;
                for (var i = 0; i < levelCount; i++)
                {
                    var node = nodes.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }

                result.Add(sum * 1d / levelCount);
            }

            return result;
        }
    }
}
