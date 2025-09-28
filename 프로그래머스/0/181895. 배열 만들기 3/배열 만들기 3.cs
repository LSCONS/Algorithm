using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr, int[,] intervals) 
    {
        int[] result = new int[0];
        for(int i = 0; i < intervals.GetLength(0); i++)
        {
            int start = intervals[i, 0];
            int end = intervals[i, 1];
            result = result.Concat(arr.Where((x, index) => index >= start && index <= end).ToArray()).ToArray();
        }
        return result;
    }
}