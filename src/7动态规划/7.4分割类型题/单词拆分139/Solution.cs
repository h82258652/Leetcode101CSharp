using System.Collections.Generic;

namespace 单词拆分139
{
    public class Solution
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            int n = s.Length;

            bool[] dp = new bool[n + 1];
            dp[0] = true;

            for (int i = 1; i <= n; i++)
            {
                foreach (var word in wordDict)
                {
                    int len = word.Length;
                    if (i >= len && s.Substring(i - len, len) == word)
                    {
                        dp[i] = dp[i] || dp[i - len];
                    }
                }
            }

            return dp[n];
        }
    }
}
