namespace 最小覆盖子串76
{
    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            // 思路
            // 步骤一：不断增大 right 使滑动窗口增大，直到窗口包含了 T 的所有字符
            // 步骤二：不断增大 left 使滑动窗口缩小，因为是要求最小子串，所有将不必要的元素排除在外，使长度减小，直到碰到
            //         一个必须包含的元素，这个时候不能再扔了，再扔就不满足条件了，记录此时滑动窗口的长度，并保存最小值
            // 步骤三：让 left 再增加一个位置，这个时候滑动窗口肯定不满足条件了，那么继续从步骤一开始执行，寻找新的满足条
            //         件的滑动窗口，如此反复，直到 right 超出了字符串 S 范围
            // --------------------------------------------------------------------------------------------------------

            // 首先创建的是 need 数组表示每个字符在 t 中需要的数量，用 ASCII 码保存
            // 加入 need[76] = 2，表明 ASCII 码为 76 的这个字符在目标字符串 t 中需要两个，如果是负数表明当前字符在窗口中是多余的，需要过滤掉
            int[] need = new int[128];
            // 按照字符串 t 的内容向 need 中添加元素
            for (int i = 0; i < t.Length; i++)
            {
                need[t[i]]++;
            }

            /*
             * left：滑动窗口左边界
             * right：滑动窗口右边界
             * size：窗口的长度
             * count：当次遍历中还需要几个字符才能满足包含 t 中所有字符的条件，最大也就是 t 的长度
             * start：如果有效更新滑动窗口，记录这个窗口的起始位置，方便后续找字串用
             */
            int left = 0;
            int right = 0;
            int size = int.MaxValue;
            int count = t.Length;
            int start = 0;
            // 循环条件右边界不超过 s 的长度
            while (right < s.Length)
            {
                char c = s[right];
                // 表示 t 中包含当前遍历到的这个 c 字符，更新目前所需要的 count 数大小，应该减少一个
                if (need[c] > 0)
                {
                    count--;
                }

                // 无论这个字符是否包含在 t 中，need[] 数组中对应那个字符的计数都减少 1，利用正负区分这个字符是多余的还是有用的
                need[c]--;
                // count==0 说明当前的窗口已经满足了包含 t 所需所有字符的条件
                if (count == 0)
                {
                    // 如果左边界这个字符对应的值在 need[] 数组中小于 0，说明他是一个多余元素，不包含在 t 内
                    while (left < right && need[s[left]] < 0)
                    {
                        // 在 need[] 数组中维护更新这个值，增加 1
                        need[s[left]]++;
                        // 左边界向右移，过滤掉这个元素
                        left++;
                    }

                    // 如果当前的这个窗口值比之前维护的窗口值更小，需要进行更新
                    if (right - left + 1 < size)
                    {
                        // 更新窗口值
                        size = right - left + 1;
                        // 更新窗口起始位置，方便之后找到这个位置返回结果
                        start = left;
                    }

                    // 先将 left 位置的字符计数重新加 1
                    need[s[left]]++;

                    // 重新维护左边界值和当前所需字符的值 count
                    left++;
                    count++;
                }

                // 右移边界，开始下一次循环
                right++;
            }

            return size == int.MaxValue ? "" : s.Substring(start, size);
        }
    }
}
