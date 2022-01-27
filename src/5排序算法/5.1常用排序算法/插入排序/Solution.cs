namespace 插入排序
{
    public class Solution
    {
        public void InsertionSort(int[] nums, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j > 0 && nums[j] < nums[j - 1]; j--)
                {
                    (nums[j], nums[j - 1]) = (nums[j - 1], nums[j]);
                }
            }
        }
    }
}
