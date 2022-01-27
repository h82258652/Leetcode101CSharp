namespace _4的幂342
{
    public class Solution
    {
        public bool IsPowerOfFour(int n)
        {
            // 0xaaaaaaaa 等于 0b10101010101010101010101010101010
            return n > 0 && (n & (n - 1)) == 0 && (n & 0xaaaaaaaa) == 0;
        }
    }
}
