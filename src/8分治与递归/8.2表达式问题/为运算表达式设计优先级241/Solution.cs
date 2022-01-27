using System.Collections.Generic;

namespace 为运算表达式设计优先级241
{
    public class Solution
    {
        public IList<int> DiffWaysToCompute(string expression)
        {
            List<int> ways = new List<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == '+' || c == '-' || c == '*')
                {
                    IList<int> left = DiffWaysToCompute(expression.Substring(0, i));
                    IList<int> right = DiffWaysToCompute(expression.Substring(i + 1));

                    foreach (var l in left)
                    {
                        foreach (var r in right)
                        {
                            switch (c)
                            {
                                case '+':
                                    ways.Add(l + r);
                                    break;

                                case '-':
                                    ways.Add(l - r);
                                    break;

                                case '*':
                                    ways.Add(l * r);
                                    break;
                            }
                        }
                    }
                }
            }

            if (ways.Count == 0)
            {
                ways.Add(int.Parse(expression));
            }

            return ways;
        }
    }
}
