using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] array, int n) 
    {
        var ary = array
            .Select(x => new{origin = x, abs = Math.Abs(x - n)})
            .OrderBy(x => x.abs)
            .ToArray();
        
        int first = ary.First().abs;
        ary = ary.Where(x => x.abs == first).OrderBy(x => x.origin).ToArray();
        
        return ary.First().origin;
    }
}