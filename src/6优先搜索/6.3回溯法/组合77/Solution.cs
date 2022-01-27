using System.Collections.Generic;

namespace 组合77
{
    public class Solution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> ans = new List<IList<int>>();
            Stack<int> comb = new Stack<int>();
            backtracking(ans, comb, 1, n, k);
            return ans;
        }

        private void backtracking(List<IList<int>> ans, Stack<int> comb, int pos, int n, int k)
        {
            if (comb.Count == k)
            {
                ans.Add(new List<int>(comb));
                return;
            }

            for (int i = pos; i <= n; i++)
            {
                comb.Push(i);// 修改当前节点状态
                backtracking(ans, comb, i + 1, n, k);// 递归子节点
                comb.Pop();// 回改当前节点状态
            }
        }
    }
}
