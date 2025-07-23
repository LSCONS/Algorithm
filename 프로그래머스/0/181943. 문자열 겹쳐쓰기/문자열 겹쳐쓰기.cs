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
        public string solution(string my_string, string overwrite_string, int s)
        {
            StringBuilder sb = new StringBuilder();
            int myCount = my_string.Length;
            int overwriteSumCount = overwrite_string.Length + s;

            sb.Append(my_string.Substring(0, s));
            sb.Append(overwrite_string);
            if(myCount > overwriteSumCount)
            {
                sb.Append(my_string.Substring(overwriteSumCount, myCount - overwriteSumCount));
            }
            return sb.ToString();
        }
    }