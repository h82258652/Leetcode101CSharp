namespace 数组中的第K个最大元素215
{
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int left = 0;
            int right = nums.Length - 1;
            int target = nums.Length - k;
            while (left < right)
            {
                int mid = QuickSelection(nums, left, right);
                if (mid == target)
                {
                    return nums[mid];
                }

                if (mid < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return nums[left];
        }

        private int QuickSelection(int[] nums, int left, int right)
        {
            int i = left + 1;
            int j = right;
            while (true)
            {
                while (i < right && nums[i] <= nums[left])
                {
                    i++;
                }

                while (left < j && nums[j] >= nums[left])
                {
                    j--;
                }

                if (i >= j)
                {
                    break;
                }

                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
            (nums[left], nums[j]) = (nums[j], nums[left]);
            return j;
        }
    }
}
