namespace 两数之和II输入有序数组167
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            // 思路，因为 numbers 已经排好序，所以从左右分别缩小范围

            var l = 0;
            var r = numbers.Length - 1;
            int sum;
            while (l < r)
            {
                sum = numbers[l] + numbers[r];
                if (sum == target)
                {
                    break;
                }

                if (sum < target)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            // 题目的下标从 1 开始计数
            return new[] { l + 1, r + 1 };
        }
    }
}
