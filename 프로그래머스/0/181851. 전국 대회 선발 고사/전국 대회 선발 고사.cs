using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] rank, bool[] attendance) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < rank.Length; i++)dict[rank[i]] = i;
        List<int> list = rank
            .Where((x, index) => attendance[index])
            .OrderBy(x => x)
            .Take(3)
            .ToList();
        
        int result = 0;
        
        result += dict[list[0]] * 10000;
        result += dict[list[1]] * 100;
        result += dict[list[2]] * 1;
        
        return result;
    }
}