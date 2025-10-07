using System;
using System.Linq;

public class Solution 
{
    public int solution(string my_string) 
        => new string(
            my_string        
             .Select(x => char.IsDigit(x) ? x : ' ')       
             .ToArray())
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .Sum(); 
}