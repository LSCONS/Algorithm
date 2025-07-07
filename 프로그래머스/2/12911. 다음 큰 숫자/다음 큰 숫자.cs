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

    class Solution
    {
        public int solution(int n)
        {
            int firstIndex = int.MaxValue;
            bool isFirst = true;
            int allIndex = 0;

            for( int i= 0; i < 32; i++)
            {
                int j = 1 << i;
                if((j | n) == n)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    allIndex++;
                }
                else
                {
                    if(!isFirst)
                    {
                        firstIndex = i;
                        isFirst = false;
                        break;
                    }
                }
            }

            int result = 0;
            if (firstIndex == int.MaxValue)
            {
                for(int i= 0; i < allIndex - 1; i++)
                {
                    result += 1 << i;
                }
                result += 1 << (allIndex);
                return result;
            }

            for (int i = 0; i < allIndex - 1; i++)
            {
                result += 1 << i;
            }
            result += 1 << firstIndex;
            for (int i = firstIndex + 1; i < 32; i++)
            {
                int j = 1 << i;
                if ((j | n) == n)
                {
                    result += j;
                }
            }
            return result;
        }
    }