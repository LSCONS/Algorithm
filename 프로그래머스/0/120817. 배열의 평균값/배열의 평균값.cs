using System;
using System.Linq;

public class Solution 
{
    public double solution(int[] numbers) 
    {
        int length = numbers.Length;
        int sum = numbers.Sum();
        return (double)sum / length;
    }
}