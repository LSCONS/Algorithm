using System;

public class Solution 
{
    public int solution(int n) 
    {
        int temp = 1;
        int result = 0;
        for(int i= 1; temp <= n; i++)
        {
            temp *= i;
            result++;
        }
        return result - 1;
    } 
}