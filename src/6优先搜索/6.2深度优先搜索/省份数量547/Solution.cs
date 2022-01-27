namespace 省份数量547
{
    public class Solution
    {
        public int FindCircleNum(int[][] isConnected)
        {
            // 思路，每找到一个未访问的，数量加1，然后遍历相连节点将其标记为已访问

            int n = isConnected.Length;
            int count = 0;
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    Dfs(isConnected, i, visited);
                    count++;
                }
            }

            return count;
        }

        private void Dfs(int[][] isConnected, int i, bool[] visited)
        {
            visited[i] = true;
            for (int k = 0; k < isConnected.Length; k++)
            {
                if (isConnected[i][k] == 1 && !visited[k])
                {
                    Dfs(isConnected, k, visited);
                }
            }
        }
    }
}
