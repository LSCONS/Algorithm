using System;

public class Solution 
{
    public int solution(int order) 
    {
        int result = 0;
        while(order > 0)
        {
            int temp = order % 10;
            if(temp != 0 && temp % 3 == 0) result++;
            order /= 10;
        }
        return result;
    }
}