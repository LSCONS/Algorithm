using System;
using System.Linq;

public class Solution 
{
    public int solution(string before, string after) 
    {
        return new string(before.OrderBy(x => x).ToArray()) == new string(after.OrderBy(x => x).ToArray()) ? 1 : 0;
    }
}