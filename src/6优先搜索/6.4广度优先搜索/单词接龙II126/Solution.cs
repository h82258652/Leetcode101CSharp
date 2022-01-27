using System.Collections.Generic;

namespace 单词接龙II126
{
    public class Solution
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            List<IList<string>> res = new List<IList<string>>();
            // 因为需要快速判断扩展出的单词是否在 wordList 里，因此需要将 wordList 存入哈希表，这里命名为「字典」
            HashSet<string> dict = new HashSet<string>(wordList);
            // 特殊用例判断
            if (!dict.Contains(endWord))
            {
                return res;
            }

            dict.Remove(beginWord);

            // 第 1 步：广度优先遍历建图
            // 记录扩展出的单词是在第几次扩展的时候得到的，key：单词，value：在广度优先遍历的第几层
            Dictionary<string, int> steps = new Dictionary<string, int>();
            steps[beginWord] = 0;

            // 记录了单词是从哪些单词扩展而来，key：单词，value：单词列表，这些单词可以变换到 key，它们是一对多关系
            Dictionary<string, List<string>> from = new Dictionary<string, List<string>>();
            int step = 1;
            bool found = false;
            int wordLen = beginWord.Length;
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    string currWord = queue.Dequeue();
                    char[] charArray = currWord.ToCharArray();

                    // 将每一位替换成 26 个小写英文字母

                    for (int j = 0; j < wordLen; j++)
                    {
                        char origin = charArray[j];
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            charArray[j] = c;
                            string nextWord = new string(charArray);
                            if (steps.ContainsKey(nextWord) && step == steps[nextWord])
                            {
                                from[nextWord].Add(currWord);
                            }

                            if (!dict.Contains(nextWord))
                            {
                                continue;
                            }

                            // 如果从一个单词扩展出来的单词以前遍历过，距离一定更远，为了避免搜索到已经遍历到，且距离更远的单词，需要将它从 dict 中删除
                            dict.Remove(nextWord);
                            // 这一层扩展出的单词进入队列
                            queue.Enqueue(nextWord);

                            // 记录 nextWord 从 currWord 而来
                            from.TryAdd(nextWord, new List<string>());
                            from[nextWord].Add(currWord);

                            // 记录 nextWord 的 step
                            steps[nextWord] = step;
                            if (nextWord == endWord)
                            {
                                found = true;
                            }
                        }

                        charArray[j] = origin;
                    }
                }

                step++;
                if (found)
                {
                    break;
                }
            }

            // 第 2 步：深度优先遍历找到所有解，从 endWord 恢复到 beginWord，所以每次尝试操作 path 列表的头部
            if (found)
            {
                LinkedList<string> path = new LinkedList<string>();
                path.AddLast(endWord);
                dfs(from, path, beginWord, endWord, res);
            }

            return res;
        }

        private void dfs(Dictionary<string, List<string>> from, LinkedList<string> path, string beginWord, string cur, List<IList<string>> res)
        {
            if (cur == beginWord)
            {
                res.Add(new List<string>(path));
                return;
            }

            foreach (var precursor in @from[cur])
            {
                path.AddFirst(precursor);
                dfs(from, path, beginWord, precursor, res);
                path.RemoveFirst();
            }
        }
    }
}
