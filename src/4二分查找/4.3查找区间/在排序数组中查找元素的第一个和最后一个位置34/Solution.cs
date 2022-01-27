namespace 在排序数组中查找元素的第一个和最后一个位置34
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return new[] { -1, -1 };
            }

            var lowerBound = LowerBound(nums, target);
            if (nums[lowerBound] != target)
            {
                // 查找失败
                return new[] { -1, -1 };
            }

            var upperBound = UpperBound(nums, target);

            return new[] { lowerBound, upperBound };
        }

        private int LowerBound(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;// 防止溢出
                if (nums[mid] < target)
                {
                    // 中间的小于目标，说明在右区间，且不包含中间这个元素
                    left = mid + 1;
                }
                else if (nums[mid] == target)
                {
                    // 目标可能是这个，也可能在这个的左边连续相同的元素，收窄右区间
                    right = mid;
                }
                else
                {
                    // 中间的大于目标，说明在左区间，且不包含中间这个元素
                    right = mid - 1;
                }
            }

            // 因为循环条件是 left<right，而每次操作只会步进1，所以跳出的时候，left和right是相等的，取left和right都可以
            return left;
        }

        private int UpperBound(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                var mid = (left + right + 1) / 2;// 尽量取靠右边的那个元素
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] == target)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}
