namespace 搜索旋转排序数组II81
{
    public class Solution
    {
        public bool Search(int[] nums, int target)
        {
            // 思路，查找出来中间的数如果跟左区间相等的话，回退到顺序查找，将左区间 left 往右加 1 收窄继续循环

            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return true;
                }

                if (nums[left] == nums[mid])
                {
                    left++;
                }
                else if (nums[mid] <= nums[right])
                {
                    // 右区间是增序的
                    if (target > nums[mid] && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    // 左区间是增序的
                    if (target >= nums[left] && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }

            return false;
        }
    }
}
