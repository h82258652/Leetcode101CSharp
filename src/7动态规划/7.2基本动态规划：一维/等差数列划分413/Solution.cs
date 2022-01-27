using System.Linq;

namespace 等差数列划分413
{
    public class Solution
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            int n = nums.Length;
            if (n < 3)
            {
                return 0;
            }

            int[] dp = new int[n];
            for (int i = 2; i < n; i++)
            {
                if (nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2])
                {
                    dp[i] = dp[i - 1] + 1;
                }
            }

            return dp.Sum();
        }
    }
}
