using System;
using System.Text;

public class Solution 
{
    public string solution(string my_string, string alp) 
    {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < my_string.Length; i++)
        {
            if(my_string[i] == alp[0])
            {
                sb.Append(char.ToUpper(my_string[i]));
            }
            else
            {
                sb.Append(my_string[i]);
            }
        }
        
        return sb.ToString();
    }
}