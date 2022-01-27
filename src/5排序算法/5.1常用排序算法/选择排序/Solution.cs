namespace 选择排序
{
    public class Solution
    {
        public void SelectionSort(int[] nums, int n)
        {
            int mid;
            for (int i = 0; i < n - 1; i++)
            {
                mid = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] < nums[mid])
                    {
                        mid = j;
                    }
                }

                (nums[mid], nums[i]) = (nums[i], nums[mid]);
            }
        }
    }
}
