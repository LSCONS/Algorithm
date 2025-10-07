using System;
using System.Linq;

public class Solution 
{
    public string solution(string s) 
        => new string(s
        .GroupBy(x => x)
        .Where(x => x.Count() == 1)
        .Select(x => x.Key)
        .OrderBy(x => x)
        .ToArray());
}