using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) 
        => new string(my_string.Select(x => char.ToLower(x)).OrderBy(x => x).ToArray());
}