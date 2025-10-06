using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(string[] s1, string[] s2) 
    {
        HashSet<string> hash = new HashSet<string>(s1);
        return s2.Count(x => hash.Contains(x));
    }
}