using System.Collections.Generic;

namespace 滑动窗口最大值239
{
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            LinkedList<int> dq = new LinkedList<int>();
            List<int> ans = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dq.Count > 0 && dq.First.Value == i - k)
                {
                    dq.RemoveFirst();
                }

                while (dq.Count > 0 && nums[dq.Last.Value] < nums[i])
                {
                    dq.RemoveLast();
                }

                dq.AddLast(i);

                if (i >= k - 1)
                {
                    ans.Add(nums[dq.First.Value]);
                }
            }

            return ans.ToArray();
        }
    }
}
