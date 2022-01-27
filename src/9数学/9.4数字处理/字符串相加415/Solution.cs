using System;
using System.IO.Pipes;
using System.Linq;
using System.Text;

namespace 字符串相加415
{
    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            int i = num1.Length - 1;// 将指针放到个位上
            int j = num2.Length - 1;
            int add = 0;// 进位标记

            StringBuilder buffer = new StringBuilder();

            while (i >= 0 || j >= 0 || add != 0)
            {
                int x = 0;
                if (i >= 0)
                {
                    x = num1[i] - '0';
                }

                int y = 0;
                if (j >= 0)
                {
                    y = num2[j] - '0';
                }

                int result = x + y + add;
                buffer.Append(result % 10);

                add = result / 10;
                i--;
                j--;
            }

            // 计算完以后的答案需要翻转过来
            return new string(buffer.ToString().Reverse().ToArray());
        }
    }
}
