﻿using System;

namespace 打乱数组384
{
    public class Solution
    {
        private int[] nums;
        private int[] original;

        public Solution(int[] nums)
        {
            this.nums = nums;
            this.original = new int[nums.Length];
            Array.Copy(nums, original, nums.Length);
        }

        public int[] Reset()
        {
            Array.Copy(original, nums, nums.Length);
            return nums;
        }

        public int[] Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                int j = random.Next(i, nums.Length);
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            return nums;
        }
    }
}
