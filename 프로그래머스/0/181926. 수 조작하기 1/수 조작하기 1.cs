using System;
using System.Text;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int n, string control) 
    {
        int answer = n;
        foreach(char c in control)
        {
            answer += GetInt[c];
        }
        return answer;
    }
    
    public static Dictionary<char, int> GetInt = new Dictionary<char, int>()
    {
        {'w', 1},
        {'s', -1},
        {'d', 10},
        {'a', -10},
    };
}