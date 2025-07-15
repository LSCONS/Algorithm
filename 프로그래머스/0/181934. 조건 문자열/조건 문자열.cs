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
        public int solution(string ineq, string eq, int n, int m)
        {
            bool isResult;
            StringBuilder sb = new StringBuilder();
            sb.Append(ineq);
            sb.Append(eq);
            string str = sb.ToString();
            switch (str)
            {
                case "<=": isResult = n <= m; break;
                case "<!": isResult = n < m; break;
                case ">=": isResult = n >= m; break;
                case ">!": isResult = n > m; break;
                default: isResult = false; break;
            }
            return isResult ? 1 : 0;
        }
    }