using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;

    public class Solution
    {
        List<int> answerList = new List<int>();
        string result = string.Empty;
        int upCount = 0;

        public int solution(string begin, string target, string[] words)
        {

            HashSet<string> wordSet = new HashSet<string>(words);
            if (!wordSet.Contains(target)) return 0;
            wordSet.Add(begin);
            result = target;

            GetNextWord(begin, wordSet);

            if (answerList.Count == 0) return 0;
            return answerList.Min();
        }


        public void GetNextWord(string current, HashSet<string> wordSet)
        {
            if (current == result)
            {
                answerList.Add(upCount);
                return;
            }
            upCount++;
            wordSet.Remove(current);
            HashSet<string> nextWordSet = new HashSet<string>();
            foreach (string word in wordSet)
            {
                int diffCount = 0;
                for (int i = 0; i < current.Length; i++)
                {
                    if (current[i] != word[i])
                    {
                        diffCount++;
                    }
                    if (diffCount > 1) break;
                }
                if (diffCount == 1) nextWordSet.Add(word);
            }

            foreach (string nextWord in nextWordSet)
            {
                GetNextWord(nextWord, wordSet);
            }
            wordSet.Add(current);
            upCount--;
        }
    }