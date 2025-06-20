using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

    class Solution
    {
        public int[] solution(int n, string[] words)
        {
            HashSet<string> visited = new HashSet<string>();
            int[] answer = new int[] { 0, 0 };
            int temp = 0;
            char lastChar = words[0][0];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][0] != lastChar)
                {
                    temp = i;
                    break;
                }


                if (visited.Contains(words[i]))
                {
                    temp = i;
                    break;
                }
                else
                {
                    visited.Add(words[i]);
                    lastChar = words[i][words[i].Length - 1];
                }


            }

            if(temp != 0)
            {
                answer = new int[] { temp % n + 1, temp / n + 1 };
            }

            return answer;
        }
    }