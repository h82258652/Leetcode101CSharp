﻿using System;
using System.Collections.Generic;

namespace 最大单词长度乘积318
{
    public class Solution
    {
        public int MaxProduct(string[] words)
        {
            int length = words.Length;
            int[] masks = new int[length];
            for (int i = 0; i < length; i++)
            {
                string word = words[i];
                int wordLength = word.Length;
                for (int j = 0; j < wordLength; j++)
                {
                    masks[i] |= 1 << (word[j] - 'a');
                }
            }

            int maxProd = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if ((masks[i] & masks[j]) == 0)
                    {
                        maxProd = Math.Max(maxProd, words[i].Length * words[j].Length);
                    }
                }
            }

            return maxProd;
        }
    }
}
