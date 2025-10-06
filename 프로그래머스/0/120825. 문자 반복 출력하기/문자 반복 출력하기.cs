using System;
using System.Linq;

public class Solution 
{
    public string solution(string my_string, int n) 
    {
        return new string(my_string
            .ToCharArray()
            .SelectMany(x => Enumerable.Repeat(x, n))
            .ToArray());
    }
}