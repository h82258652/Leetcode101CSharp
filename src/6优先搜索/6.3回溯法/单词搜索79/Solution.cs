namespace 单词搜索79
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            if (board.Length == 0)
            {
                return false;
            }

            int m = board.Length;
            int n = board[0].Length;

            bool[][] visited = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            bool find = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    backtracking(i, j, board, word, ref find, visited, 0);
                }
            }

            return find;
        }

        private void backtracking(int i, int j, char[][] board, string word, ref bool find, bool[][] visited, int pos)
        {
            if (i < 0 || i >= board.Length ||
                j < 0 || j >= board[0].Length)
            {
                return;
            }

            if (visited[i][j] || find || board[i][j] != word[pos])
            {
                return;
            }

            if (pos == word.Length - 1)
            {
                find = true;
                return;
            }

            visited[i][j] = true;// 修改当前节点状态
            // 递归子节点
            backtracking(i + 1, j, board, word, ref find, visited, pos + 1);
            backtracking(i - 1, j, board, word, ref find, visited, pos + 1);
            backtracking(i, j + 1, board, word, ref find, visited, pos + 1);
            backtracking(i, j - 1, board, word, ref find, visited, pos + 1);
            visited[i][j] = false;// 回改当前节点状态
        }
    }
}
