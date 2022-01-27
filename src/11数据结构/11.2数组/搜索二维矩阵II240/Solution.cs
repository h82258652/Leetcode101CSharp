namespace 搜索二维矩阵II240
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            // 思路，从右上角搜索到左下角

            int m = matrix.Length;
            if (m == 0)
            {
                return false;
            }

            int n = matrix[0].Length;
            int i = 0;
            int j = n - 1;

            while (i < m && j >= 0)
            {
                if (matrix[i][j] == target)
                {
                    return true;
                }
                else if (matrix[i][j] > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return false;
        }
    }
}
