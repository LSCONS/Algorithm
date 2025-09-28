using System;
using System.Text;

public class Solution 
{
    public string solution(string myString) 
    {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < myString.Length; i++)
        {
            if(myString[i] == 'a' || myString[i] == 'A')
            {
                sb.Append('A');
            }
            else
            {
                sb.Append(char.ToLower(myString[i]));
            }
        }
        
        return sb.ToString();
    }
}