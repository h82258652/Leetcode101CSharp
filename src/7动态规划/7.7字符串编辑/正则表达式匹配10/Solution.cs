namespace 正则表达式匹配10
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;

            bool[][] dp = new bool[m + 1][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new bool[n + 1];
            }

            dp[0][0] = true;

            for (int i = 1; i < n + 1; i++)
            {
                if (p[i - 1] == '*')
                {
                    dp[0][i] = dp[0][i - 2];
                }
            }

            for (int i = 1; i < m + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (p[j - 1] == '.')// 任意字符
                    {
                        dp[i][j] = dp[i - 1][j - 1];
                    }
                    else if (p[j - 1] != '*')// 不是 * 也不是 .
                    {
                        dp[i][j] = dp[i - 1][j - 1] && p[j - 1] == s[i - 1];
                    }
                    else if (p[j - 2] != s[i - 1] && p[j - 2] != '.')// 是 *，且 p 前一个字符跟 s 不匹配，且 p 前一个字符不是 .
                    {
                        dp[i][j] = dp[i][j - 2];
                    }
                    else
                    {
                        dp[i][j] = dp[i][j - 1] || dp[i - 1][j] || dp[i][j - 2];
                    }
                }
            }

            return dp[m][n];
        }
    }
}
