using System;
using System.Text;

public class Solution 
{
    public string solution(string polynomial) 
    {
        StringBuilder sb = new StringBuilder();
        int xCount = 0;
        int numCount = 0;
        string[] split = polynomial.Split(" + ");
        for(int i = 0; i < split.Length; i++)
        {
            
            if(split[i].Contains("x"))
            {
                string s = split[i].Replace("x", "");
                if(string.IsNullOrEmpty(s)) s = "1";
                xCount += int.Parse(s);
            }
            else
            {
                numCount += int.Parse(split[i]);
            }
        }
        if(xCount != 0)
        {
            if(xCount != 1) sb.Append(xCount.ToString());
            sb.Append("x");
        }
        if(numCount != 0)
        {
            if(xCount != 0) sb.Append(" + ");
            sb.Append(numCount.ToString());
        }
        return sb.ToString();
    }
}