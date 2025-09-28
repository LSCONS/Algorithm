using System;
using System.Linq;

public class Solution 
{
    public string[] solution(string[] strArr) 
    {
        return strArr
            .Select((x, i) => i % 2 == 0 ? x.ToLower() : x.ToUpper())
            .ToArray();
    }
}