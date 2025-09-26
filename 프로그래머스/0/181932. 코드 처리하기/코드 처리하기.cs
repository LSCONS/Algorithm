using System;
using System.Text;

public class Solution 
{
    public string solution(string code) 
    {
        bool evenMode = true;
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < code.Length; i++)
        {
            if(code[i]  == '1')
            {
                evenMode = !evenMode;
            }
            else if(evenMode && i % 2  == 0)
            {
                sb.Append(code[i]);
            }
            else if(!evenMode && i % 2 == 1)
            {
                sb.Append(code[i]);
            }
        }
        string result = sb.ToString();
        return result == "" ? "EMPTY" : sb.ToString();
    }
}