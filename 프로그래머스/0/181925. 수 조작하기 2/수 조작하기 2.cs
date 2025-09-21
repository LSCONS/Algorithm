using System;
using System.Text;
using System.Collections.Generic;

public class Solution 
{
    public string solution(int[] numLog) 
    {
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < numLog.Length - 1; i++)
        {
            int result = numLog[i + 1] - numLog[i];
            sb.Append(GetString[result]);
        }
        
        return sb.ToString();
    }
    
    private Dictionary<int, string> GetString = new Dictionary<int, string>() 
    {
        {1, "w"},
        {-1, "s"},
        {10, "d"},
        {-10, "a"},
    };
}