using System.Linq;

namespace 分割等和子集416
{
    public class Solution
    {
        public bool CanPartition(int[] nums)
        {
            int n = nums.Length;
            if (n < 2)
            {
                return false;
            }

            int sum = nums.Sum();
            int maxNum = nums.Max();

            // 数组无法分成两份相等的
            if (sum % 2 != 0)
            {
                return false;
            }

            // 存在元素大于一半
            int target = sum / 2;
            if (maxNum > target)
            {
                return false;
            }

            // dp 数组每一行表示 nums 的每一个数，列表示从 [0,target] 是否能满足
            bool[][] dp = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new bool[target + 1];
                dp[i][0] = true;
            }

            dp[0][nums[0]] = true;// 第一个数只能满足到 nums[0]，即它自身

            for (int i = 1; i < n; i++)
            {
                int num = nums[i];
                for (int j = 1; j <= target; j++)
                {
                    if (j >= num)
                    {
                        dp[i][j] = dp[i - 1][j] | dp[i - 1][j - num];
                    }
                    else
                    {
                        dp[i][j] = dp[i - 1][j];
                    }
                }
            }

            return dp[n - 1][target];
        }
    }
}
