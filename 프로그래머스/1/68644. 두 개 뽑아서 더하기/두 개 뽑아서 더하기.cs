using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;

    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            HashSet<int> visited = new HashSet<int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    int addNum = numbers[i] + numbers[j];
                    visited.Add(addNum);
                }
            }
            answer = visited.OrderBy(x => x).ToArray();
            return answer;
        }
    }