using System;

public class Solution 
{
    public int[] solution(int[] numbers, string direction) 
    {
        int length = numbers.Length;
        int[] result = new int[length];
        
        bool isLeft = direction == "left";
        
        int startValue = numbers[0];
        int endValue = numbers[length - 1];
        
        int startIndex = isLeft ? 0 : 2;
        for(int i = 1; i < length - 1; i++)
        {
            result[startIndex++] = numbers[i];
        }
        
        if(isLeft)
        {
            result[length - 2] = endValue;
            result[length - 1] = startValue;
        }
        else
        {
            result[0] = endValue;
            result[1] = startValue;
        }
        
        return result;
    }
}