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
        public int[] solution(int[] arr, int[] query)
        {
            List<int> temp = arr.ToList();
            for(int i = 0; i < query.Length; i++)
            {
                int removeIndex = 0;
                if(i % 2 == 0)
                {
                    removeIndex = query[i] + 1;
                    for(int j = temp.Count - 1; j >= removeIndex; j--)
                    {
                        temp.RemoveAt(j);
                    }
                }
                else
                {
                    removeIndex = query[i] - 1;
                    for (int j = removeIndex; j >= 0; j--)
                    {
                        temp.RemoveAt(j);
                    }
                }
            }
            return temp.ToArray();
        }
    }