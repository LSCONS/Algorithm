using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] array) 
    {
        var result = array
            .GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .Take(2)
            .Select(x => new int[]{x.Key, x.Count()})
            .ToArray();
        
        if(result.Length == 1 || result[0][1] != result[1][1]) return result[0][0];
        return -1;
    }
}