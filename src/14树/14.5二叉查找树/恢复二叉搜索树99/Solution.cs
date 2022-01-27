using System.Collections.Generic;

namespace 恢复二叉搜索树99
{
    public class Solution
    {
        public void RecoverTree(TreeNode root)
        {
            List<int> nums = new List<int>();
            Inorder(root, nums);
            int[] swapped = FindTwoSwapped(nums);
            Recover(root, 2, swapped[0], swapped[1]);
        }

        private void Inorder(TreeNode root, List<int> nums)
        {
            if (root == null)
            {
                return;
            }

            Inorder(root.left, nums);
            nums.Add(root.val);
            Inorder(root.right, nums);
        }

        private int[] FindTwoSwapped(List<int> nums)
        {
            int n = nums.Count;
            int index1 = -1;
            int index2 = -1;
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i + 1] < nums[i])
                {
                    index2 = i + 1;
                    if (index1 == -1)
                    {
                        index1 = i;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int x = nums[index1];
            int y = nums[index2];
            return new[] { x, y };
        }

        private void Recover(TreeNode root, int count, int x, int y)
        {
            if (root != null)
            {
                if (root.val == x || root.val == y)
                {
                    root.val = root.val == x ? y : x;
                    if (--count == 0)
                    {
                        return;
                    }
                }

                Recover(root.right, count, x, y);
                Recover(root.left, count, x, y);
            }
        }
    }
}
