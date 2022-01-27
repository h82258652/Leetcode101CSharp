namespace 同构字符串205
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            int[] s_first_index = new int[256];
            int[] t_first_index = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                if (s_first_index[s[i]] != t_first_index[t[i]])
                {
                    return false;
                }

                s_first_index[s[i]] = t_first_index[t[i]] = i + 1;
            }

            return true;
        }
    }
}
