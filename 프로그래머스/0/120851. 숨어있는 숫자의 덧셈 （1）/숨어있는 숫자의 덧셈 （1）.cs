using System;
using System.Linq;

public class Solution 
{
    public int solution(string my_string) 
    {
        return my_string
            .Where(char.IsDigit)
            .Sum(x => x - '0');
    }
}