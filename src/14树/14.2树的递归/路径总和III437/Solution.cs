namespace 路径总和III437
{
    public class Solution
    {
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return 0;
            }

            int result = RootSum(root, targetSum);
            result += PathSum(root.left, targetSum);
            result += PathSum(root.right, targetSum);
            return result;
        }

        private int RootSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return 0;
            }

            int result = 0;
            int val = root.val;
            if (val == targetSum)
            {
                result++;
            }

            result += RootSum(root.left, targetSum - val);
            result += RootSum(root.right, targetSum - val);
            return result;
        }
    }
}
