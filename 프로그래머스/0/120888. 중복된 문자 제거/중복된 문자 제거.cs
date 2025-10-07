using System;
using System.Linq;

public class Solution 
{
    public string solution(string my_string) 
        => new string(my_string.GroupBy(x => x).Select(x => x.Key).ToArray());
}