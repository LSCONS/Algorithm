using System;

public class Solution 
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2) 
    {
        int up = numer1 * denom2 + numer2 * denom1;
        int down = denom1 * denom2;
        
        int upCopy = up;
        int downCopy = down;
        
        while(downCopy != 0)
        {
            int temp = downCopy;
            downCopy = upCopy % downCopy;
            upCopy = temp;
        }
        
        return new int[]{up / upCopy, down / upCopy};
    }
}