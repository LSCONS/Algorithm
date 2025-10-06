using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        Array.Sort(numbers);
        return Math.Max(numbers[0] * numbers[1], numbers[numbers.Length - 1] * numbers[numbers.Length - 2]);
    }
}