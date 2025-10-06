using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] array) 
    {
        return array
            .OrderBy(x => x)
            .Skip(array.Length / 2)
            .First();
    }
}