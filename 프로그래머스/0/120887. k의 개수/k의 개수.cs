using System;
using System.Linq;

public class Solution 
{
    public int solution(int i, int j, int k) 
        => Enumerable
        .Range(i, j - i + 1)
        .Select(x => x.ToString().Count(y => y == (char)(k + '0')))
        .Sum();
}