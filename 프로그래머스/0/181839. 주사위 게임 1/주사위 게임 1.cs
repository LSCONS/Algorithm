using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        bool aEven = a % 2 == 0;
        bool bEven = b % 2 == 0;
        
        if(aEven && bEven)
        {
            return Math.Abs(a - b);
        }
        
        if(!aEven && !bEven)
        {
            return a * a + b * b;
        }
        
        return 2 * (a + b);
    }
}