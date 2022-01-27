namespace _3的幂326
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            // 思路，在 int 范围内，3 的最大次方 3^19 是 1162261467

            return n > 0 && 1162261467 % n == 0;
        }
    }
}
