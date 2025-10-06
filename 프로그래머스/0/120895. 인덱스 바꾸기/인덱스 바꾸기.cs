using System;
using System.Linq;

public class Solution 
{
    public string solution(string my_string, int num1, int num2) 
    {
        char[] temp = my_string.ToCharArray();
        temp[num1] = my_string[num2];
        temp[num2] = my_string[num1];
        return new string(temp);
    }
}