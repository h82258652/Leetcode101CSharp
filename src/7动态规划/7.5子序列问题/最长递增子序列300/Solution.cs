using System;

namespace 最长递增子序列300
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int[] dp = new int[nums.Length];// 以i结尾，能得到最长的上升子序列长度
            dp[0] = 1;
            int maxans = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }

                maxans = Math.Max(maxans, dp[i]);
            }

            return maxans;
        }
    }
}
