namespace 汉明距离461
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int diff = x ^ y;
            int ans = 0;
            while (diff > 0)
            {
                ans += diff & 1;
                diff >>= 1;
            }

            return ans;
        }
    }
}
