using System;
using System.Collections.Generic;

namespace N皇后51
{
    public class Solution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> ans = new List<IList<string>>();

            if (n == 0)
            {
                return ans;
            }

            // 初始化 n × n 格子都为 .
            char[][] board = new char[n][];
            for (int i = 0; i < n; i++)
            {
                board[i] = new char[n];
                Array.Fill(board[i], '.');
            }

            bool[] column = new bool[n];
            bool[] ldiag = new bool[2 * n - 1];
            bool[] rdiag = new bool[2 * n - 1];
            backtracking(ans, board, column, ldiag, rdiag, 0, n);
            return ans;
        }

        private void backtracking(List<IList<string>> ans, char[][] board, bool[] column, bool[] ldiag, bool[] rdiag, int row, int n)
        {
            if (row == n)
            {
                var temp = new List<string>();
                for (var i = 0; i < board.Length; i++)
                {
                    temp.Add(new string(board[i]));
                }

                ans.Add(temp);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (column[i] || ldiag[n - row + i - 1] || rdiag[row + i])
                {
                    continue;
                }

                // 修改当前节点状态
                board[row][i] = 'Q';
                column[i] = ldiag[n - row + i - 1] = rdiag[row + i] = true;

                // 递归子节点
                backtracking(ans, board, column, ldiag, rdiag, row + 1, n);

                // 回改当前节点状态
                board[row][i] = '.';
                column[i] = ldiag[n - row + i - 1] = rdiag[row + i] = false;
            }
        }
    }
}
