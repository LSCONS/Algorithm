using System;
using System.Text;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        StringBuilder sb = new StringBuilder();
        foreach(char c in pat)
        {
            char temp = c == 'A' ? 'B' : 'A';
            sb.Append(temp);
        }
        int answer = myString.Contains(sb.ToString()) ? 1 : 0;
        return answer;
    }
}