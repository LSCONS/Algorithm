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
        public int[] solution(int[] numbers)
        {
            Stack<int> ints = new Stack<int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                while(ints.Count > 0 && numbers[ints.Peek()] < numbers[i])
                {
                    int idx = ints.Pop();
                    numbers[idx] = numbers[i];
                }
                ints.Push(i);
            }

            foreach (var idx in ints)
            {
                numbers[idx] = -1;
            }

            return numbers;
        }
    }