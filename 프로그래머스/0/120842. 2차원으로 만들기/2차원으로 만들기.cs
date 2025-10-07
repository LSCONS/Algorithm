using System;

public class Solution 
{
    public int[,] solution(int[] num_list, int n) 
    {
        int length = num_list.Length;
        int[,] result = new int[length / n, n];
        for(int i = 0; i < length; i++)
        {
            result[i / n, i % n] = num_list[i]; 
        }
        return result;
    }
}