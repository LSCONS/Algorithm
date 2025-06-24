using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System;

    public class Solution
    {
        public int solution(int[] citations)
        {
            int answer = 0;

            int n = citations.Length;
            Array.Sort(citations);

            for(int i = 0; i < n; i++)
            {
                int hIndex = n - i;
                if (citations[i] >= hIndex)
                {
                    answer = hIndex;
                    break;
                }
            }

            return answer;
        }
    }