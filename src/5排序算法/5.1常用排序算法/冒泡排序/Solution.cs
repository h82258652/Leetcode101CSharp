namespace 冒泡排序
{
    public class Solution
    {
        public void BubbleSort(int[] nums, int n)
        {
            bool swapped;
            for (int i = 1; i < n; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i + 1; j++)
                {
                    if (nums[j] < nums[j - 1])
                    {
                        (nums[j], nums[j - 1]) = (nums[j - 1], nums[j]);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
