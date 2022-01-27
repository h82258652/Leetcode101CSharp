﻿using System;
using System.Collections.Generic;

namespace 两数之和1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashtable = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashtable.ContainsKey(target - nums[i]))
                {
                    return new int[] { hashtable[target - nums[i]], i };
                }

                hashtable[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}
