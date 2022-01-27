using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace 找到所有数组中消失的数字448
{
    public class Solution
    {
        public IList<int> FindDisapperaredNumbers(int[] nums)
        {
            int len = nums.Length;
            int index = 0;
            while (index < len)
            {
                if (nums[index] == index + 1)
                {
                    index++;
                }
                else
                {
                    int targetIndex = nums[index] - 1;
                    if (nums[targetIndex] == nums[index])
                    {
                        index++;
                        continue;
                    }

                    int temp = nums[targetIndex];
                    nums[targetIndex] = nums[index];
                    nums[index] = temp;
                }
            }

            List<int> res = new List<int>();
            for (int i = 0; i < len; i++)
            {
                if (nums[i] != i + 1)
                {
                    res.Add(i + 1);
                }
            }

            return res;
        }
    }
}
