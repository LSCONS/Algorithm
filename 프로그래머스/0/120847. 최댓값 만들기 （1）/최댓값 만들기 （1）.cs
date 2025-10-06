using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        return numbers
            .OrderBy(x => x)
            .Skip(numbers.Length - 2)
            .Aggregate((a, b) => a * b);
    }
}