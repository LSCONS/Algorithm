using System;
using System.Linq;

public class Solution 
{
    public int[] solution(string my_string) 
    {
        return my_string
            .Where(char.IsDigit)
            .OrderBy(x => x)
            .Select(x => x - '0')
            .ToArray();
    }
}