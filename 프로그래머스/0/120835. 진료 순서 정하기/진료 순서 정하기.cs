using System;
using System.Linq;
using System.Collections.Generic;


public class Solution 
{
    public int[] solution(int[] emergency) 
    {
        Dictionary<int, int> orderBy = emergency
            .OrderByDescending(x => x)
            .Select((value, index) => new {value, index})
            .ToDictionary(x => x.value, x => x.index + 1);
        
        return emergency.Select(x => orderBy[x]).ToArray();
    }
}