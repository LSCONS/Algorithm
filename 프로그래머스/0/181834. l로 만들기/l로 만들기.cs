using System;
using System.Text;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string myString) 
    {
        StringBuilder sb = new StringBuilder();
        foreach(char c in myString)
        {
            if((int)c < (int)('l'))
            {
                sb.Append('l');
            }
            else
            {
                sb.Append(c);   
            }
        }
        return sb.ToString();
    }
}