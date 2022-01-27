using System;

namespace 一和零474
{
    public class Solution
    {
        public int FindMaxForm(string[] strs, int m, int n)
        {
            int[][] dp = new int[m + 1][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[n + 1];
            }

            foreach (var str in strs)
            {
                var count = Count(str);
                var count0 = count.Item1;
                var count1 = count.Item2;

                for (int i = m; i >= count0; i--)
                {
                    for (int j = n; j >= count1; j--)
                    {
                        dp[i][j] = Math.Max(dp[i][j], 1 + dp[i - count0][j - count1]);
                    }
                }
            }

            return dp[m][n];
        }

        private Tuple<int, int> Count(string s)
        {
            int count0 = s.Length;
            int count1 = 0;
            foreach (var c in s)
            {
                if (c == '1')
                {
                    count1++;
                    count0--;
                }
            }

            return new Tuple<int, int>(count0, count1);
        }
    }
}
