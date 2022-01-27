namespace 公倍数与公因数
{
    public class Solution
    {
        /// <summary>
        /// 辗转相除法求最大公因数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }

        /// <summary>
        /// 最小公倍数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Lcm(int a, int b)
        {
            return a * b / Gcd(a, b);
        }
    }
}
