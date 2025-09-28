using System;
using System.Linq;

public class Solution 
{
    public string[] solution(string my_string) 
    {
        string[] result = new string[my_string.Length];
        for(int i= 0; i < my_string.Length; i++)
        {
            result[i] = my_string.Substring(i, my_string.Length - i);
        }
        
        result = result
            .OrderBy(x => x)
            .ToArray();
        
        return result;
    }
}