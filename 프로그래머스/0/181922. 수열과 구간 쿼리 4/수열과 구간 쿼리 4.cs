using System;

public class Solution 
{
    public int[] solution(int[] arr, int[,] queries) 
    {
        int height = queries.GetLength(0);
        for(int i = 0; i < height; i++)
        {
            for(int j = queries[i, 0]; j <= queries[i, 1]; j++)
            {
                if(j % queries[i, 2] == 0) arr[j] += 1;
            }
        }
        return arr;
    }
}