using System;

namespace 计数质数204
{
    public class Solution
    {
        public int CountPrimes(int n)
        {
            if (n <= 2)
            {
                return 0;
            }

            bool[] prime = new bool[n];
            Array.Fill(prime, true);

            int count = n - 2;// 去掉不是质数的 1
            for (int i = 2; i < n; i++)
            {
                if (prime[i])
                {
                    for (int j = 2 * i; j < n; j += i)
                    {
                        if (prime[j])
                        {
                            prime[j] = false;
                            count--;
                        }
                    }
                }
            }

            return count;
        }
    }
}
