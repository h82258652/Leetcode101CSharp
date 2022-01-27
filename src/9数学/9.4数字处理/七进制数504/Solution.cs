using System.Text;

namespace 七进制数504
{
    public class Solution
    {
        public string ConvertToBase7(int num)
        {
            if (num == 0)
            {
                return "0";
            }

            var isNegative = num < 0;

            if (isNegative)
            {
                num = -num;
            }

            var ans = new StringBuilder();
            while (num > 0)
            {
                var a = num / 7;
                var b = num % 7;
                ans.Insert(0, b);
                num = a;
            }

            if (isNegative)
            {
                ans.Insert(0, "-");
                return ans.ToString();
            }
            else
            {
                return ans.ToString();
            }
        }
    }
}
