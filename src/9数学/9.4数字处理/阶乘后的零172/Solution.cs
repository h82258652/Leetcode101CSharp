namespace 阶乘后的零172
{
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            // 思路，结尾 0 由 2 * 5 得来，而质因子中 2 的数量比 5 多，计算 5 数量即可
            int zeroCount = 0;
            while (n > 0)
            {
                n /= 5;
                zeroCount += n;
            }

            return zeroCount;
        }
    }
}
