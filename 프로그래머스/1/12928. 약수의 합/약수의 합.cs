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
        public int solution(int n)
        {
            if (n == 0) return 0;
            HashSet<int> set = new HashSet<int>();
            int answer = 0;
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                if(n % i == 0)
                {
                    set.Add(i);
                    set.Add(n / i);
                }
            }

            foreach (var item in set)
            {
                answer += item;
            }
            return answer;
        }
    }