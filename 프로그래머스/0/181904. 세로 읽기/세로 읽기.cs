using System;
using System.Text;

public class Solution 
{
    public string solution(string my_string, int m, int c) 
    {
        StringBuilder sb = new StringBuilder();
        int length = (my_string.Length - 1) / m + 1;
        
        for(int i = 0; i < length; i++)
        {
            sb.Append(my_string[i * m + (c - 1)]);
        }
        
        return sb.ToString();
    }
}