using System;

public class Solution 
{
    public int solution(string number) 
    {
        int sum = 0;
        for(int i = 0; i < number.Length; i++)
        {
            sum += number[i] - '0';
        }
        return sum % 9;
    }
}