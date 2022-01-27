namespace 归并排序
{
    public class Solution
    {
        public void MergeSort(int[] nums, int left, int right, int[] temp)
        {
            if (left + 1 >= right)
            {
                return;
            }

            int m = left + (right - left) / 2;
            MergeSort(nums, left, m, temp);
            MergeSort(nums, m, right, temp);
            int p = left;
            int q = m;
            int i = left;
            while (p < m || q < right)
            {
                if (q >= right || (p < m && nums[p] <= nums[q]))
                {
                    temp[i++] = nums[p++];
                }
                else
                {
                    temp[i++] = nums[q++];
                }
            }

            for (int j = left; j < right; j++)
            {
                nums[j] = temp[j];
            }
        }
    }
}
