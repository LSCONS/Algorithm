using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        return arr
            .SelectMany(x => Enumerable.Repeat(x, x))
            .ToArray();
    }
}