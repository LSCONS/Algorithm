using System;

public class Solution 
{
    public int solution(int n) 
    {
        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n ? 1 : 2;
    }
}