using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] box, int n) 
    {
        return box
            .Select(x => x / n)
            .Aggregate((a, b) => a * b);
    }
}