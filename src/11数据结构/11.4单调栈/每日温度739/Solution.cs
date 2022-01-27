using System.Collections.Generic;

namespace 每日温度739
{
    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            int[] ans = new int[temperatures.Length];
            Stack<int> indices = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                while (indices.Count > 0)
                {
                    int pre_index = indices.Peek();
                    if (temperatures[i] <= temperatures[pre_index])
                    {
                        break;
                    }

                    indices.Pop();
                    ans[pre_index] = i - pre_index;
                }

                indices.Push(i);
            }

            return ans;
        }
    }
}
