using System;

public class Solution 
{
    public int solution(int[] dot) 
    {
        bool isPositiveX = dot[0] > 0;
        bool isPositiveY = dot[1] > 0;
        if(isPositiveX) return isPositiveY ? 1 : 4;
        else return isPositiveY ? 2 : 3;
    }
}