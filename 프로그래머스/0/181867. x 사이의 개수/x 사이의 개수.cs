using System;
using System.Linq;

public class Solution 
{
    public int[] solution(string myString) 
    {
        string[] result = myString.Split('x');
        return result
            .Select(x => x.Length)
            .ToArray();
    }
}