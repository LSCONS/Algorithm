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
        public int[] solution(int[] numlist, int n)
        {
            return numlist
                .OrderBy(i => MathF.Abs(i - n))
                .ThenBy(i => i < n) 
                .ToArray();
        }
    }