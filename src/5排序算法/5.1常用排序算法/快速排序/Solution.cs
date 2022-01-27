namespace 快速排序
{
    public class Solution
    {
        public void QuickSort(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
        }

        private void QuickSort(int[] nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pivot = nums[start + (end - start) / 2];// 枢轴的值，取中间，取区间第一个，或者随机取区间中的其中一个都可以
            int left = start;
            int right = end;

            while (left <= right)
            {
                while (left <= right && nums[left] < pivot)// 在左边找到第一个比枢轴大的
                {
                    left++;
                }
                while (left <= right && nums[right] > pivot)// 在右边找到第一个比枢轴小的
                {
                    right--;
                }

                if (left <= right)// 找到的话就交换它们
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);

                    left++;
                    right--;
                }
            }

            // sort nums[start... right]
            QuickSort(nums, start, right);
            // sort nums[left ... end]
            QuickSort(nums, left, end);
        }
    }

    //public class Solution
    //{
    //    public void QuickSort(int[] nums, int left, int right)
    //    {
    //        if (left + 1 >= right)
    //        {
    //            return;
    //        }

    //        int first = left;
    //        int last = right - 1;
    //        int key = nums[first];
    //        while (first < last)
    //        {
    //            while (first < last && nums[last] >= key)
    //            {
    //                last--;
    //            }

    //            nums[first] = nums[last];

    //            while (first < last && nums[first] <= key)
    //            {
    //                first++;
    //            }

    //            nums[last] = nums[first];
    //        }

    //        nums[first] = key;
    //        QuickSort(nums, left, first);
    //        QuickSort(nums, first + 1, right);
    //    }
    //}
}
