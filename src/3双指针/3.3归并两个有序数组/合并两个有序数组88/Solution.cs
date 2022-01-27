namespace 合并两个有序数组88
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // 思路，两个数组已经排好序，初始指针在 m + n - 1，也就是 nums1 空间最后
            // 然后从前往后检测 nums1 和 nums2，将元素放到 nums1 后面空白空间

            var pos = m + n - 1;
            var nums1Pos = m - 1;
            var nums2Pos = n - 1;

            while (nums1Pos >= 0 && nums2Pos >= 0)
            {
                if (nums1[nums1Pos] > nums2[nums2Pos])
                {
                    nums1[pos] = nums1[nums1Pos];

                    nums1Pos--;
                    pos--;
                }
                else
                {
                    nums1[pos] = nums2[nums2Pos];

                    nums2Pos--;
                    pos--;
                }
            }

            // nums2 可能有剩余元素没合并到 nums1 上
            while (nums2Pos >= 0)
            {
                nums1[pos] = nums2[nums2Pos];

                pos--;
                nums2Pos--;
            }
        }
    }
}
