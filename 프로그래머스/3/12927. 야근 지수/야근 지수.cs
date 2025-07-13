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
        public long solution(long n, int[] works)
        {
            long lastNum = 0;
            long lastCount = 0;
            long betweenNum = 0;
            long betweenCount = 0;
            Stack<long> stack = new Stack<long>();

            Array.Sort(works);
            foreach (var work in works)
            {
                stack.Push(work);
            }

            lastNum = stack.Pop();
            lastCount++;

            while (n > 0)
            {
                while(stack.Count > 0 && stack.Peek() == lastNum)
                {
                    stack.Pop();
                    lastCount++;
                }

                if(stack.Count > 0)
                {
                    long dif = lastNum - stack.Peek();
                    if(n < dif * lastCount)
                    {
                        long a = n / lastCount;
                        long b = n % lastCount;
                        lastNum -= a;
                        lastCount -= b;
                        betweenNum = lastNum - 1;
                        betweenCount = b;
                        n = 0;
                    }
                    else
                    {
                        lastNum -= dif;
                        n -= dif * lastCount;
                    }
                }
                else
                {
                    long a = n / lastCount;
                    long b = n % lastCount;
                    lastNum -= a;
                    lastCount -= b;
                    betweenNum = lastNum - 1;
                    betweenCount = b;
                    n = 0;
                }
            }

            if (lastNum <= 0) return 0;

            long result = 0;

            foreach(int i in stack)
            {
                result += i * i;
            }

            result += lastNum * lastNum * lastCount;
            result += betweenNum * betweenNum * betweenCount;

            return result;
        }
    }