using System.Collections.Generic;

namespace 全排列46
{
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            // 思路，将已处理的数字交换到前面，下一层从这个数字往后（不包含）处理

            List<IList<int>> ans = new List<IList<int>>();
            backtracking(nums, 0, ans);
            return ans;
        }

        private void backtracking(int[] nums, int level, List<IList<int>> ans)
        {
            if (level == nums.Length - 1)
            {
                ans.Add(new List<int>(nums));
                return;
            }

            for (int i = level; i < nums.Length; i++)
            {
                (nums[i], nums[level]) = (nums[level], nums[i]);// 修改当前节点状态
                backtracking(nums, level + 1, ans);// 递归子节点
                (nums[i], nums[level]) = (nums[level], nums[i]);// 回改当前节点状态
            }
        }
    }
}
