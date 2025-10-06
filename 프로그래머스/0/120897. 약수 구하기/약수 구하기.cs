using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int n) 
    {
        HashSet<int> hash = new HashSet<int>();
        for(int i = 1; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0)
            {
                hash.Add(i);
                hash.Add(n / i);
            }
        }
        return hash.OrderBy(x => x).ToArray();
    }
}