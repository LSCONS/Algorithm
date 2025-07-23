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
        public int solution(int[] diffs, int[] times, long limit)
        {
            int count = 0;
            int maxLenght = diffs.Length;
            int level = 0;
            int addLevel = 0;
            int maxCount = int.MaxValue;
            int gap = 0;
            long result = 0;
            bool isCan = true;
            
            while (true)
            {
                isCan = true;
                addLevel = 1 << count;
                result = 0;
                gap = diffs[0] - (level + addLevel);
                if (gap < 0) gap = 0;
                result = result + (gap + 1) * times[0];

                for (int i = maxLenght - 1; i >= 1; i--)
                {
                    gap = diffs[i] - (level + addLevel);
                    if (gap < 0) gap = 0;

                    result = result + gap * (times[i] + times[i - 1]) + times[i];
                    if (result > limit)
                    {
                        isCan = false;
                        break;
                    }
                }

                if (isCan)
                {
                    if (count == 0)
                    {
                        return level + addLevel;
                    }
                    level += (1 << (count - 1));
                    maxCount = count;
                    count = 0;
                }
                else
                {
                    count++;
                    if (count >= maxCount)
                    {
                        level += addLevel;
                        maxCount = count - 1;
                        count = 0;
                    }
                }
            }
        }
    }