namespace SqrtX69
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            // x 的开方必然位于 [1,x] 之间
            int left = 1;
            int right = x;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;// 防止溢出
                int sqrt = x / mid;
                if (sqrt == mid)
                {
                    return mid;
                }

                if (mid > sqrt)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            // 最终跳出循环的时候，必然 left 大于 right，所以这里返回 right
            return right;
        }
    }
}
