using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] array, int height) 
    {
        return array
            .Where(x => x > height)
            .ToArray()
            .Length;
    }
}