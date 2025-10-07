using System;
using System.Linq;

public class Solution 
{
    public string solution(int age) 
        => new string(age.ToString().Select(x => (char)(x + 49)).ToArray());
}