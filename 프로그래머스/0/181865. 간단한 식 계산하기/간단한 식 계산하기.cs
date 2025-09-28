using System;

public class Solution 
{
    public int solution(string binomial) 
    {
        string[] result = binomial.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int a = int.Parse(result[0]);
        int b = int.Parse(result[2]);
        string sign = result[1];
        
        if(sign == "+") return a + b;
        if(sign == "-") return a - b;
        if(sign == "*") return a * b;
        return -1;
    }
}