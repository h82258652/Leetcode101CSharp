using System.Collections.Generic;

namespace 有效的括号20
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> parsed = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                {
                    parsed.Push(s[i]);
                }
                else
                {
                    if (parsed.Count <= 0)
                    {
                        return false;
                    }

                    char c = parsed.Peek();
                    if ((s[i] == '}' && c == '{') ||
                        (s[i] == ']' && c == '[') ||
                        (s[i] == ')' && c == '('))
                    {
                        parsed.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return parsed.Count == 0;
        }
    }
}
