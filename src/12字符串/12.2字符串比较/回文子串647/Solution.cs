namespace 回文子串647
{
    public class Solution
    {
        public int CountSubstrings(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count += ExtendSubstrings(s, i, i);// 奇数长度
                count += ExtendSubstrings(s, i, i + 1);// 偶数长度
            }

            return count;
        }

        private int ExtendSubstrings(string s, int l, int r)
        {
            int count = 0;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
                count++;
            }

            return count;
        }
    }
}
